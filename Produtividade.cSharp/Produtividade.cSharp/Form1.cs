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

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lazerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prioridadesCriadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var casa = new Prio_casa();
            casa.ShowDialog();

        }

        private void semPrioridadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cs = new Casa();
            cs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prioridadesCriadas9ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var src = new Emprego();
            src.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var es = new Estudos();
            es.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            var lz = new Lazer();
            lz.ShowDialog();
        }


    }
}
