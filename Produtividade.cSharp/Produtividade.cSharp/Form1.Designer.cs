namespace Produtividade.cSharp
{
    partial class Form1
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
            this.lblOrientacao = new System.Windows.Forms.Label();
            this.btnEscolhaCasa = new System.Windows.Forms.Button();
            this.btnSevico = new System.Windows.Forms.Button();
            this.btnEstudos = new System.Windows.Forms.Button();
            this.btnLazer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrientacao
            // 
            this.lblOrientacao.AutoSize = true;
            this.lblOrientacao.Location = new System.Drawing.Point(12, 9);
            this.lblOrientacao.Name = "lblOrientacao";
            this.lblOrientacao.Size = new System.Drawing.Size(238, 91);
            this.lblOrientacao.TabIndex = 0;
            this.lblOrientacao.Text = "Vamos aumentar a produtividade ? \r\n\r\n\r\n Começaremos com esses assuntos \r\n\r\n\r\n Som" +
    "ente escolha , e te ajudarei a se empenhar .";
            // 
            // btnEscolhaCasa
            // 
            this.btnEscolhaCasa.Location = new System.Drawing.Point(55, 375);
            this.btnEscolhaCasa.Name = "btnEscolhaCasa";
            this.btnEscolhaCasa.Size = new System.Drawing.Size(75, 23);
            this.btnEscolhaCasa.TabIndex = 1;
            this.btnEscolhaCasa.Text = "Casa";
            this.btnEscolhaCasa.UseVisualStyleBackColor = true;
            // 
            // btnSevico
            // 
            this.btnSevico.Location = new System.Drawing.Point(195, 375);
            this.btnSevico.Name = "btnSevico";
            this.btnSevico.Size = new System.Drawing.Size(75, 23);
            this.btnSevico.TabIndex = 2;
            this.btnSevico.Text = "Serviço ";
            this.btnSevico.UseVisualStyleBackColor = true;
            // 
            // btnEstudos
            // 
            this.btnEstudos.Location = new System.Drawing.Point(330, 375);
            this.btnEstudos.Name = "btnEstudos";
            this.btnEstudos.Size = new System.Drawing.Size(75, 23);
            this.btnEstudos.TabIndex = 3;
            this.btnEstudos.Text = "Estudos";
            this.btnEstudos.UseVisualStyleBackColor = true;
            // 
            // btnLazer
            // 
            this.btnLazer.Location = new System.Drawing.Point(459, 375);
            this.btnLazer.Name = "btnLazer";
            this.btnLazer.Size = new System.Drawing.Size(75, 23);
            this.btnLazer.TabIndex = 4;
            this.btnLazer.Text = "Lazer";
            this.btnLazer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 432);
            this.Controls.Add(this.btnLazer);
            this.Controls.Add(this.btnEstudos);
            this.Controls.Add(this.btnSevico);
            this.Controls.Add(this.btnEscolhaCasa);
            this.Controls.Add(this.lblOrientacao);
            this.Name = "Form1";
            this.Text = "A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrientacao;
        private System.Windows.Forms.Button btnEscolhaCasa;
        private System.Windows.Forms.Button btnSevico;
        private System.Windows.Forms.Button btnEstudos;
        private System.Windows.Forms.Button btnLazer;
    }
}

