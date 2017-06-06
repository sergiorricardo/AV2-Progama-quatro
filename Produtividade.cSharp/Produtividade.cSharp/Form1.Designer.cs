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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.casaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casaToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.estudosToolStripMenuItem,
            this.lazerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(575, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // casaToolStripMenuItem
            // 
            this.casaToolStripMenuItem.Name = "casaToolStripMenuItem";
            this.casaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.casaToolStripMenuItem.Text = "Casa";
            this.casaToolStripMenuItem.Click += new System.EventHandler(this.casaToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 432);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "A";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem casaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lazerToolStripMenuItem;
    }
}

