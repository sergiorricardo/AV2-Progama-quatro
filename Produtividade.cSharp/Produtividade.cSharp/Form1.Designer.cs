namespace Produtividade.cSharp
{
    partial class Inicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.casaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empregoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrientacao
            // 
            this.lblOrientacao.AutoSize = true;
            this.lblOrientacao.Location = new System.Drawing.Point(12, 9);
            this.lblOrientacao.Name = "lblOrientacao";
            this.lblOrientacao.Size = new System.Drawing.Size(0, 13);
            this.lblOrientacao.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casaToolStripMenuItem,
            this.empregoToolStripMenuItem,
            this.estudosToolStripMenuItem,
            this.lazerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // casaToolStripMenuItem
            // 
            this.casaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filhosToolStripMenuItem});
            this.casaToolStripMenuItem.Name = "casaToolStripMenuItem";
            this.casaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.casaToolStripMenuItem.Text = "Casa";
            this.casaToolStripMenuItem.Click += new System.EventHandler(this.casaToolStripMenuItem_Click);
            // 
            // empregoToolStripMenuItem
            // 
            this.empregoToolStripMenuItem.Name = "empregoToolStripMenuItem";
            this.empregoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.empregoToolStripMenuItem.Text = "Emprego";
            this.empregoToolStripMenuItem.Click += new System.EventHandler(this.empregoToolStripMenuItem_Click);
            // 
            // estudosToolStripMenuItem
            // 
            this.estudosToolStripMenuItem.Name = "estudosToolStripMenuItem";
            this.estudosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.estudosToolStripMenuItem.Text = "Estudos";
            this.estudosToolStripMenuItem.Click += new System.EventHandler(this.estudosToolStripMenuItem_Click);
            // 
            // lazerToolStripMenuItem
            // 
            this.lazerToolStripMenuItem.Name = "lazerToolStripMenuItem";
            this.lazerToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.lazerToolStripMenuItem.Text = "Lazer";
            this.lazerToolStripMenuItem.Click += new System.EventHandler(this.lazerToolStripMenuItem_Click);
            // 
            // filhosToolStripMenuItem
            // 
            this.filhosToolStripMenuItem.Name = "filhosToolStripMenuItem";
            this.filhosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filhosToolStripMenuItem.Text = "Filhos";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 432);
            this.Controls.Add(this.lblOrientacao);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicial";
            this.Text = "Tala_Inicial ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrientacao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem casaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empregoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filhosToolStripMenuItem;
    }
}

