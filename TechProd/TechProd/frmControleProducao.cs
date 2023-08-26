using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProd
{
    public partial class frmControleProducao : Form
    {
        public frmControleProducao()
        {
            InitializeComponent();
        }

        string strconexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbTechProd;User ID=sa;Password=sql2022";
        SqlConnection conexao;
        double codigo;
        private void frmControleProducao_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblCargo", strconexao);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            cmbCargo.DataSource = tabela;
            cmbCargo.DisplayMember = "Descricao";
            cmbCargo.ValueMember = "codCargo";           

            cmbCargo.SelectedIndex = -1;
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;           
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCargo = cmbCargo.SelectedItem.ToString();

            using (SqlCommand command = new SqlCommand(strconexao)) ;
            {
                conexao.Open();
                string query = "SELECT nome FROM tblFuncionario WHERE codCargo = (SELECT codCargo FROM tblCargo WHERE descricao = @descricao";
                using (SqlCommand command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@descricao", selectedCargo);
                    SqlDataReader reader = command.ExecuteReader();

                    cmbFuncionario.Items.Clear();
                    while (reader.Read())
                    {
                        string nomeFuncionario = reader["nome"].ToString();
                        cmbFuncionario.Items.Add(nomeFuncionario);
                    }
                }
            }
        }

        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectFuncionario = cmbFuncionario.SelectedItem.ToString();

            using (SqlConnection conexao = new SqlConnection(strconexao))
            {
                conexao.Open();
                string query = "SELECT salrioBase FROM tblFuncionario WHERE nome = @nomeFuncionario";
                using (SqlCommand command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@nomeFuncionario", selectFuncionario);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        double salarioBase = Convert.ToDouble(result);
                        txtSalarioBase.Text = salarioBase.ToString("C");
                    }
                    else
                    {
                        txtSalarioBase.Text = "Nenhum salário base encontrado!";
                    }
                }
            }
        }

        private void txtValorReceber_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInconsistencia.Text))
            {
               double valorReceber = Convert.ToDouble(txtValorReceber.Text);
               double salarioBase = Convert.ToDouble(txtSalarioBase.Text);
               double horaExtra = Convert.ToDouble(txtHoraExtra.Text);
               double inconssistencia = Convert.ToDouble(txtInconsistencia.Text);

                valorReceber = salarioBase + (salarioBase / 220 * horaExtra) - (inconssistencia * 3) - (50);
                             
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexao = new SqlConnection(strconexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "INSERT INTO tblRegistro VALUES(@codFuncionario, @mes, @dtEntrega, @inconsistencia, @hrExtra, @valorReceber";
            cmd.Parameters.AddWithValue("mes", cmbMes.Text);
            cmd.Parameters.AddWithValue("@dtEntrega", txtDataEntrega.Text);

        }
    }
}
