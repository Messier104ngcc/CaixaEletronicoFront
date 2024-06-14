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
    public partial class MenuBanck : Form
    {
        public MenuBanck()
        {
            InitializeComponent();
        }

        private void MenuBanck_Load(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_depositar_Click(object sender, EventArgs e)
        {
            var teladepositar = new Tela_Depositar();
            teladepositar.Show();

            this.Visible = false;
        }

        private void button_sacar_Click(object sender, EventArgs e)
        {
            var telaSacar = new Tela_Sacar();
            telaSacar.Show();

            this.Visible = false;
        }

        private void linkLabel_suporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.instagram.com/l_santos.s/";

            try
            {
                VisitLink();
            }
            catch 
            {
                MessageBox.Show("ERRO AO ABRIR O LINK", "ERRO" , MessageBoxButtons.OK, MessageBoxIcon.Error);

                linkLabel_suporte.Focus();
            }
        }

     
        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/l_santos.s/");
        }
    }
}
