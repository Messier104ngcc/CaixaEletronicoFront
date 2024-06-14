using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoFront
{
    public partial class CadastroBank : Form
    {
        public CadastroBank()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var termos = new Termos();
            termos.Show();

            this.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var form1 = new Tela_Login();
            form1.Show();

            this.Visible = false;
        }
    }
}
