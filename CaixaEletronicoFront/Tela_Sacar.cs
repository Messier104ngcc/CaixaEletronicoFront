﻿using System;
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
    public partial class Tela_Sacar : Form
    {
        public Tela_Sacar()
        {
            InitializeComponent();
        }

        private void button_voltar_sacar_Click(object sender, EventArgs e)
        {
            var menuBank = new MenuBanck();
            menuBank.Show();

            this.Visible = false;
        }
    }
}
