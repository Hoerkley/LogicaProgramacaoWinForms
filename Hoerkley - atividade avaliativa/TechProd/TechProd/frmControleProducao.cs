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

        private void frmControleProducao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTechProdDataSet.tblCargo' table. You can move, or remove it, as needed.
            this.tblCargoTableAdapter.Fill(this.dbTechProdDataSet.tblCargo);

        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codCargo = Convert.ToInt32(cmbCargo.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblFuncionario WHERE codCargo = '" + codCargo + "'", strconexao);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            cmbFuncionario.DataSource = tabela;
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "codFuncionario";
        }

        private void txtValorReceber_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInconsistencia.Text))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT salarioBase FROM tblFuncionario WHERE codFuncionario = @valor";
                cmd.Parameters.AddWithValue("@valor", Convert.ToInt32(cmbFuncionario.SelectedValue));
                conexao.Open();
               
               double salarioBase = Convert.ToDouble(cmd.ExecuteScalar());
               txtSalarioBase.Text =salarioBase.ToString();
               double horaExtra = Convert.ToDouble(txtHoraExtra.Text);
               double inconssistencia = Convert.ToDouble(txtInconsistencia.Text);
               double valorReceber;

                valorReceber = salarioBase + (salarioBase / 220 * horaExtra) - (inconssistencia * 3) - (50);
                             
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexao = new SqlConnection(strconexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "INSERT INTO tblRegistro VALUES(@codFuncionario, @mes, @dtEntrega, @inconsistencia, @hrExtra, @valorReceber)";
            cmd.Parameters.AddWithValue("mes", cmbMes.Text);
            cmd.Parameters.AddWithValue("@dtEntrega", txtDataEntrega.Text);

        }

    

    
    }
}
