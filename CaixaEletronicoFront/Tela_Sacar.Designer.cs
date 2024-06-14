namespace CaixaEletronicoFront
{
    partial class Tela_Sacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Sacar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_voltar_sacar = new System.Windows.Forms.Button();
            this.button_sacar_valor = new System.Windows.Forms.Button();
            this.textBox_valor_sacar = new System.Windows.Forms.TextBox();
            this.txt_sacar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_voltar_sacar);
            this.groupBox1.Controls.Add(this.button_sacar_valor);
            this.groupBox1.Controls.Add(this.textBox_valor_sacar);
            this.groupBox1.Controls.Add(this.txt_sacar);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SACAR";
            // 
            // button_voltar_sacar
            // 
            this.button_voltar_sacar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_voltar_sacar.Location = new System.Drawing.Point(306, 106);
            this.button_voltar_sacar.Name = "button_voltar_sacar";
            this.button_voltar_sacar.Size = new System.Drawing.Size(141, 35);
            this.button_voltar_sacar.TabIndex = 3;
            this.button_voltar_sacar.Text = "VOLTAR";
            this.button_voltar_sacar.UseVisualStyleBackColor = true;
            this.button_voltar_sacar.Click += new System.EventHandler(this.button_voltar_sacar_Click);
            // 
            // button_sacar_valor
            // 
            this.button_sacar_valor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_sacar_valor.Location = new System.Drawing.Point(6, 106);
            this.button_sacar_valor.Name = "button_sacar_valor";
            this.button_sacar_valor.Size = new System.Drawing.Size(141, 35);
            this.button_sacar_valor.TabIndex = 2;
            this.button_sacar_valor.Text = "SACAR";
            this.button_sacar_valor.UseVisualStyleBackColor = true;
            // 
            // textBox_valor_sacar
            // 
            this.textBox_valor_sacar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_valor_sacar.Location = new System.Drawing.Point(110, 47);
            this.textBox_valor_sacar.Multiline = true;
            this.textBox_valor_sacar.Name = "textBox_valor_sacar";
            this.textBox_valor_sacar.Size = new System.Drawing.Size(236, 38);
            this.textBox_valor_sacar.TabIndex = 1;
            this.textBox_valor_sacar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sacar
            // 
            this.txt_sacar.AutoSize = true;
            this.txt_sacar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sacar.Location = new System.Drawing.Point(124, 19);
            this.txt_sacar.Name = "txt_sacar";
            this.txt_sacar.Size = new System.Drawing.Size(191, 25);
            this.txt_sacar.TabIndex = 0;
            this.txt_sacar.Text = "VALOR PARA SAQUE :";
            // 
            // Tela_Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 179);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Sacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button_voltar_sacar;
        private Button button_sacar_valor;
        private TextBox textBox_valor_sacar;
        private Label txt_sacar;
    }
}