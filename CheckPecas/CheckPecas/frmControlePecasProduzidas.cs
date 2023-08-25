using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CheckPecas
{
    public partial class frmControlePecasProduzidas : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbCheckPecas;User ID=sa;Password=sql2022";
        SqlConnection conexao;
        public double codigo;
        public frmControlePecasProduzidas()
        {
            InitializeComponent();
        }
        private void frmControlePecasProduzidas_Load(object sender, EventArgs e)
        {
           
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPecas", strConexao);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            cbPecas.DataSource = tabela;
            cbPecas.DisplayMember = "nomePeca";
            cbPecas.ValueMember = "codigo";

            cbPecas.SelectedIndex = -1;
            cbPecas.DropDownStyle = ComboBoxStyle.DropDownList;
            txtAprovadas.Enabled = true;
            txtReprovadas.Enabled = true;

            mtxtData.Focus();
        }

        private void mtxtData_Leave(object sender, EventArgs e)
        {          
           if(!mtxtData.MaskCompleted)
            {
                MessageBox.Show("Data invalida!") ;
                mtxtData.ResetText();
                mtxtData.Focus();
                return;
            }
           if (DateTime.Parse(mtxtData.Text) > DateTime.Now)
           {
               MessageBox.Show("A data não pode ser futura!");
               mtxtData.ResetText();
               mtxtData.Focus();
           }
        }

        private void txtReprovadas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReprovadas.Text))
            {            
                conexao = new SqlConnection(strConexao);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT prejuizo FROM tblPecas WHERE codigo = @cod";
                cmd.Parameters.AddWithValue("@cod", cbPecas.SelectedValue);
                conexao.Open();            

                double valorPrejuizo = Convert.ToDouble(cmd.ExecuteScalar());

                double reprovadas = Convert.ToDouble(txtReprovadas.Text);
                double aprovadas = double.Parse(txtAprovadas.Text);

                double produzida = aprovadas + reprovadas;
                double prejuizo = (valorPrejuizo * reprovadas) / 100;

               
               

                if (reprovadas < aprovadas)
                {
                    txtPrejuizo.Text = prejuizo.ToString("C");
                    txtProduzidas.Text = produzida.ToString();

                    if (reprovadas > 10)
                    {
                        txtEmail.Enabled = true;
                    }
                    else
                    {
                        txtEmail.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Não deve-se colocar um número maior de peças reprovadas que aprovadas!");
                    txtAprovadas.ResetText();
                    txtReprovadas.ResetText();
                    txtProduzidas.ResetText();
                    txtPrejuizo.ResetText();
                }             
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtProduzidas.Text))
            {
                    
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
