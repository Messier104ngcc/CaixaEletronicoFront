namespace CaixaEletronicoFront
{
    partial class Tela_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_entrar = new System.Windows.Forms.Button();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.textBox_conta = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.conta = new System.Windows.Forms.Label();
            this.groupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.button_cancelar);
            this.groupBox_Login.Controls.Add(this.button_cadastrar);
            this.groupBox_Login.Controls.Add(this.button_entrar);
            this.groupBox_Login.Controls.Add(this.textBox_senha);
            this.groupBox_Login.Controls.Add(this.textBox_conta);
            this.groupBox_Login.Controls.Add(this.senha);
            this.groupBox_Login.Controls.Add(this.conta);
            this.groupBox_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Login.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(400, 232);
            this.groupBox_Login.TabIndex = 0;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "LOGIN";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cancelar.Location = new System.Drawing.Point(251, 172);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(97, 38);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "CANCELAR";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cadastrar.Location = new System.Drawing.Point(252, 114);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(96, 39);
            this.button_cadastrar.TabIndex = 5;
            this.button_cadastrar.Text = "CADASTRAR";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_entrar
            // 
            this.button_entrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_entrar.Location = new System.Drawing.Point(252, 44);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(96, 38);
            this.button_entrar.TabIndex = 4;
            this.button_entrar.Text = "ENTRAR";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.Bnt_Entrar);
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(6, 148);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(185, 33);
            this.textBox_senha.TabIndex = 3;
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // textBox_conta
            // 
            this.textBox_conta.Location = new System.Drawing.Point(6, 72);
            this.textBox_conta.Name = "textBox_conta";
            this.textBox_conta.Size = new System.Drawing.Size(185, 33);
            this.textBox_conta.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(6, 120);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(80, 25);
            this.senha.TabIndex = 1;
            this.senha.Text = "SENHA :";
            // 
            // conta
            // 
            this.conta.AutoSize = true;
            this.conta.Location = new System.Drawing.Point(6, 44);
            this.conta.Name = "conta";
            this.conta.Size = new System.Drawing.Size(81, 25);
            this.conta.TabIndex = 0;
            this.conta.Text = "CONTA :";
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 256);
            this.Controls.Add(this.groupBox_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA BANCARIO L";
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox_Login;
        private Button button_cancelar;
        private Button button_cadastrar;
        private Button button_entrar;
        private TextBox textBox_senha;
        private TextBox textBox_conta;
        private Label senha;
        private Label conta;
    }
}