namespace CaixaEletronicoFront
{
    partial class MenuBanck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBanck));
            this.saldo = new System.Windows.Forms.Label();
            this.saldo_valor = new System.Windows.Forms.Label();
            this.button_depositar = new System.Windows.Forms.Button();
            this.button_sacar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.linkLabel_suporte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saldo.Location = new System.Drawing.Point(98, 29);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(113, 37);
            this.saldo.TabIndex = 0;
            this.saldo.Text = "SALDO :";
            // 
            // saldo_valor
            // 
            this.saldo_valor.AutoSize = true;
            this.saldo_valor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saldo_valor.Location = new System.Drawing.Point(117, 77);
            this.saldo_valor.Name = "saldo_valor";
            this.saldo_valor.Size = new System.Drawing.Size(70, 25);
            this.saldo_valor.TabIndex = 1;
            this.saldo_valor.Text = "SALDO";
            // 
            // button_depositar
            // 
            this.button_depositar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_depositar.Location = new System.Drawing.Point(52, 123);
            this.button_depositar.Name = "button_depositar";
            this.button_depositar.Size = new System.Drawing.Size(179, 53);
            this.button_depositar.TabIndex = 2;
            this.button_depositar.Text = "DEPOSITAR";
            this.button_depositar.UseVisualStyleBackColor = true;
            this.button_depositar.Click += new System.EventHandler(this.button_depositar_Click);
            // 
            // button_sacar
            // 
            this.button_sacar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_sacar.Location = new System.Drawing.Point(52, 202);
            this.button_sacar.Name = "button_sacar";
            this.button_sacar.Size = new System.Drawing.Size(179, 53);
            this.button_sacar.TabIndex = 3;
            this.button_sacar.Text = "SACAR";
            this.button_sacar.UseVisualStyleBackColor = true;
            this.button_sacar.Click += new System.EventHandler(this.button_sacar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_sair.Location = new System.Drawing.Point(52, 283);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(179, 53);
            this.button_sair.TabIndex = 5;
            this.button_sair.Text = "SAIR";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // linkLabel_suporte
            // 
            this.linkLabel_suporte.AutoSize = true;
            this.linkLabel_suporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_suporte.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_suporte.Location = new System.Drawing.Point(98, 366);
            this.linkLabel_suporte.Name = "linkLabel_suporte";
            this.linkLabel_suporte.Size = new System.Drawing.Size(96, 25);
            this.linkLabel_suporte.TabIndex = 6;
            this.linkLabel_suporte.TabStop = true;
            this.linkLabel_suporte.Text = "SUPORTE";
            this.linkLabel_suporte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_suporte_LinkClicked);
            // 
            // MenuBanck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 417);
            this.Controls.Add(this.linkLabel_suporte);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_sacar);
            this.Controls.Add(this.button_depositar);
            this.Controls.Add(this.saldo_valor);
            this.Controls.Add(this.saldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuBanck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MenuBanck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label saldo;
        private Label saldo_valor;
        private Button button_depositar;
        private Button button_sacar;
        private Button button_sair;
        private LinkLabel linkLabel_suporte;
    }
}