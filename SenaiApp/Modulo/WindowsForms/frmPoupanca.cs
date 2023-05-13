using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmPoupanca : Form
    {
        public frmPoupanca()
        {
            InitializeComponent();
        }      
        private void btnCalcularPoupanca_Click(object sender, EventArgs e)
        {
            var redimento = double.Parse(txtValorDepositado.Text);
            const double indice = 0.005;
            lblRendimentoPoupanca.Text = (redimento * indice).ToString() + "R$";           
            lblRendimentoPoupanca.Visible = true;            
        }
    }
}
