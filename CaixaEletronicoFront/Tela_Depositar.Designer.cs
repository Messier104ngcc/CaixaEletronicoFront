namespace CaixaEletronicoFront
{
    partial class Tela_Depositar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Depositar));
            this.txt_deposito = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_voltar_deposito = new System.Windows.Forms.Button();
            this.button_depositar_valor = new System.Windows.Forms.Button();
            this.textBox_valor_depositar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_deposito
            // 
            this.txt_deposito.AutoSize = true;
            this.txt_deposito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_deposito.Location = new System.Drawing.Point(124, 19);
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.Size = new System.Drawing.Size(218, 25);
            this.txt_deposito.TabIndex = 0;
            this.txt_deposito.Text = "VALOR PARA DEPOSITO :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_voltar_deposito);
            this.groupBox1.Controls.Add(this.button_depositar_valor);
            this.groupBox1.Controls.Add(this.textBox_valor_depositar);
            this.groupBox1.Controls.Add(this.txt_deposito);
            this.groupBox1.Location = new System.Drawing.Point(34, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPOSITAR";
            // 
            // button_voltar_deposito
            // 
            this.button_voltar_deposito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_voltar_deposito.Location = new System.Drawing.Point(306, 106);
            this.button_voltar_deposito.Name = "button_voltar_deposito";
            this.button_voltar_deposito.Size = new System.Drawing.Size(141, 35);
            this.button_voltar_deposito.TabIndex = 3;
            this.button_voltar_deposito.Text = "VOLTAR";
            this.button_voltar_deposito.UseVisualStyleBackColor = true;
            this.button_voltar_deposito.Click += new System.EventHandler(this.button_voltar_deposito_Click);
            // 
            // button_depositar_valor
            // 
            this.button_depositar_valor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_depositar_valor.Location = new System.Drawing.Point(6, 106);
            this.button_depositar_valor.Name = "button_depositar_valor";
            this.button_depositar_valor.Size = new System.Drawing.Size(141, 35);
            this.button_depositar_valor.TabIndex = 2;
            this.button_depositar_valor.Text = "DEPOSITAR";
            this.button_depositar_valor.UseVisualStyleBackColor = true;
            // 
            // textBox_valor_depositar
            // 
            this.textBox_valor_depositar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_valor_depositar.Location = new System.Drawing.Point(110, 47);
            this.textBox_valor_depositar.Multiline = true;
            this.textBox_valor_depositar.Name = "textBox_valor_depositar";
            this.textBox_valor_depositar.Size = new System.Drawing.Size(236, 38);
            this.textBox_valor_depositar.TabIndex = 1;
            this.textBox_valor_depositar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tela_Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 167);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label txt_deposito;
        private GroupBox groupBox1;
        private Button button_voltar_deposito;
        private Button button_depositar_valor;
        private TextBox textBox_valor_depositar;
    }
}