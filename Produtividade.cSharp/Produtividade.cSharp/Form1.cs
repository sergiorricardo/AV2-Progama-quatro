using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produtividade.cSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cs = new Casa();
            cs.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var src = new Emprego();
            src.ShowDialog();
        }

        private void estudosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var es = new Estudos();
            es.ShowDialog();
        }

        private void lazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lz = new Lazer();
        }

        private void prioridadesCriadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pr_cs = new Prio_casa();
            pr_cs.ShowDialog();

        }
    }
}
