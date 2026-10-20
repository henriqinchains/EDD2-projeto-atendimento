namespace Atendimento
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cmbGuiche = new System.Windows.Forms.ComboBox();
            this.lblGuiche = new System.Windows.Forms.Label();
            this.lblSenhas = new System.Windows.Forms.Label();
            this.lblAtendimentos = new System.Windows.Forms.Label();
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.lstAtendimentos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();

            // btnGerar
            this.btnGerar.Location = new System.Drawing.Point(12, 12);
            this.btnGerar.Size = new System.Drawing.Size(100, 27);
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);

            // nudQuantidade
            this.nudQuantidade.Location = new System.Drawing.Point(130, 15);
            this.nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudQuantidade.Size = new System.Drawing.Size(55, 23);

            // btnAdicionar
            this.btnAdicionar.Location = new System.Drawing.Point(195, 12);
            this.btnAdicionar.Size = new System.Drawing.Size(100, 27);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // lblGuiche
            this.lblGuiche.AutoSize = true;
            this.lblGuiche.Location = new System.Drawing.Point(330, 18);
            this.lblGuiche.Text = "Guichê:";

            // cmbGuiche
            this.cmbGuiche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuiche.Location = new System.Drawing.Point(385, 14);
            this.cmbGuiche.Size = new System.Drawing.Size(120, 23);

            // btnChamar
            this.btnChamar.Location = new System.Drawing.Point(520, 12);
            this.btnChamar.Size = new System.Drawing.Size(100, 27);
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);

            // lblSenhas
            this.lblSenhas.AutoSize = true;
            this.lblSenhas.Location = new System.Drawing.Point(12, 55);
            this.lblSenhas.Text = "Senhas";

            // lstSenhas
            this.lstSenhas.Location = new System.Drawing.Point(12, 75);
            this.lstSenhas.Size = new System.Drawing.Size(300, 300);

            // lblAtendimentos
            this.lblAtendimentos.AutoSize = true;
            this.lblAtendimentos.Location = new System.Drawing.Point(330, 55);
            this.lblAtendimentos.Text = "Atendimentos";

            // lstAtendimentos
            this.lstAtendimentos.Location = new System.Drawing.Point(330, 75);
            this.lstAtendimentos.Size = new System.Drawing.Size(300, 300);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 390);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblGuiche);
            this.Controls.Add(this.cmbGuiche);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.lblSenhas);
            this.Controls.Add(this.lstSenhas);
            this.Controls.Add(this.lblAtendimentos);
            this.Controls.Add(this.lstAtendimentos);
            this.Text = "Projeto Atendimento - Filas";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cmbGuiche;
        private System.Windows.Forms.Label lblGuiche;
        private System.Windows.Forms.Label lblSenhas;
        private System.Windows.Forms.Label lblAtendimentos;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.ListBox lstAtendimentos;
    }
}
