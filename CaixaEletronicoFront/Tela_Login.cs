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
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void Bnt_Entrar(object sender, EventArgs e)
        {
            try
            {
                if (textBox_conta.Text.Equals("1515") && textBox_senha.Text.Equals("1996"))
                {
                    //ir para a area restrita.
                    var menu = new MenuBanck(); // chama a chanela MenuBank
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox_conta.Focus(); //permite que apos clicar em ok, o cursor do mause retornara para o campo usuario.
                    textBox_senha.Text = ""; // limpara a senha apos clicar ok, caso a senha for digitado errada.
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DESCUPE.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            var cadastro = new CadastroBank();
            cadastro.Show();

            this.Visible = false;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
