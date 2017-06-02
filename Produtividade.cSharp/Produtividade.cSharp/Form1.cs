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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cs = new Casa();
            cs.MdiParent = this;
            cs.Show();
        }

        private void empregoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var em = new Emprego();
            em.MdiParent = this;
            em.Show();
        }

        private void estudosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var es = new Estudos();
            es.MdiParent = this;
            es.Show();
        }

        private void lazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var la = new Lazer();
            la.MdiParent = this;
            la.Show();
        }
    }
}
