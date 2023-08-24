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

namespace checkPecas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string conexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbCheckPecas;User ID=sa;Password= sql2022";
        SqlConnection conexaosql;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            conexaosql = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexaosql;
            cmd.CommandText = "SELECT loginUsuario FROM tblUsuarios WHERE loginUsuario = @user ";
            cmd.Parameters.AddWithValue("@user", usuario);
            conexaosql.Open();  

            if(cmd.ExecuteScalar() == null)
            {
                DialogResult resposta = MessageBox.Show("Usuario ou senha invalido!!!" + "Deseja fazer um cadastro", "CADASTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resposta == DialogResult.Yes)
                {
                    cmd.CommandText = "INSERT INTO tblUsuario VOLUES ('" + usuario + senha + ")'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro feito com sucesso" + MessageBoxIcon.Information);
                }
                else
                {
                    txtUsuario.ResetText();
                    txtSenha.ResetText();
                }
            } 
            else
            {
                cmd.CommandText = "SELECT senhaUsuario FROM tblUsuarios WHERE loginUsuario = @senha";
                cmd.Parameters.AddWithValue("@senha", senha);
                if(senha != cmd.ExecuteScalar().ToString())
                {
                    MessageBox.Show("Senha invalida!" + MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
