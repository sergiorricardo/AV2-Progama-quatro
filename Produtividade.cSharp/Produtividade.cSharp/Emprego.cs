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
    public partial class Emprego : Form
    {

        public string lavR, lavQ, lavG, bnhDG, ReEl, ReHd, Lcao, bnhCR, coPR, rEfe;
        public string prio1, prio2, prio3, prio4, prio5, prio6, prio7, prio8, prio9, prio10, prio11, prio12;

        private void ckbcs7_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbprio7.Visible = true;
            prio7 = Convert.ToString(cmbprio7);
        }

        public Emprego()
        {
            InitializeComponent();
        }

      
        private void ckbcs12_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio12.Visible = true;
            prio12 = Convert.ToString(cmbprio12);
        }

        private void ckbcs11_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio11.Visible = true;
            prio11 = Convert.ToString(cmbprio11);
        }

        private void ckbcs10_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio10.Visible = true;
            prio10 = Convert.ToString(cmbprio10);
        }

        private void ckbcs9_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio9.Visible = true;
            prio9 = Convert.ToString(cmbprio9);
        }

        private void ckbcs8_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio8.Visible = true;
            prio8 = Convert.ToString(cmbprio8);
        }


        private void ckbcs5_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio5.Visible = true;
            prio5 = Convert.ToString(cmbprio5);
        }

        private void ckbcs6_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio6.Visible = true;
            prio6 = Convert.ToString(cmbprio6);
        }

        private void ckbcs3_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio3.Visible = true;
            prio3 = Convert.ToString(cmbprio3);
        }

        private void ckbcs4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbcs2_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio2.Visible = true;
            prio2 = Convert.ToString(cmbprio2);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cmbQntPrio1.Visible = true;
            prio1 = Convert.ToString(cmbQntPrio1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Emprego_Load(object sender, EventArgs e)
        {

        }
    }
}
