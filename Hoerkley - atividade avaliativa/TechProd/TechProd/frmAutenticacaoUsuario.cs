using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProd
{
    public partial class autenticacaoUsuario : Form
    {
        public autenticacaoUsuario()
        {
            InitializeComponent();
        }

        string strconexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbTechProd;User ID=sa;Password=sql2022";
        SqlConnection conexao;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;   

            conexao = new SqlConnection(strconexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "SELECT loginFuncionario FROM tblFuncionario WHERE loginFuncionario = @login ";
            cmd.Parameters.AddWithValue("@login", usuario);
            conexao.Open();

            if(cmd.ExecuteScalar()  == null )
            {
                DialogResult resultado = MessageBox.Show("Usuário inexistente!" + MessageBoxIcon.Error);
            }
            else
            {
                cmd.CommandText = "SELECT loginFuncionario FROM tblFuncionario WHERE senha = @senha";
                cmd.Parameters.AddWithValue("@senha", senha);

                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("Usuario não cadastrado! " + MessageBoxIcon.Error);
                }
                else
                {
                    frmControleProducao fControle = new frmControleProducao();
                    fControle.ShowDialog();
                }          
            }
        }
    }
}
