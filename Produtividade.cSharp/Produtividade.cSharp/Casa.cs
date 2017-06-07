using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Produtividade.cSharp
{
    public partial class Casa : Form
            {

        public bool logado = false;
        private Conecta conn;
        public static SqlConnection ConnectOpen;
        public string lavR,lavQ,lavG,bnhDG,ReEl,ReHd,Lcao,bnhCR,coPR,rEfe;
        public string prio1="", prio2 = "", prio3 = "", prio4 = "", prio5 = "", prio6 = "", prio7 = "", prio8 = "", prio9 = "", prio10 = "", prio11 = "", prio12 = "";

        DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

        public void insere()
        {


            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into casa (id, lav_rou, lav_quint, ban_dog, lav_gar, lic_filh, rep_ele, arr_cs, lav_car, refeicao, fz_cmp, rep_hid, bnh_fil ) ");
            sql.Append("Values (@id, @lav_rou, @lav_quint, @ban_dog, @lav_gar, @lic_filh, @rep_ele, @arr_cs, @lav_car, @refeicao, @fz_cmp, @rep_hid, @bnh_fil )");
            SqlCommand command = null;



            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@id",locaDate ));
                command.Parameters.Add(new SqlParameter("@lav_rou",Convert.ToInt16(prio1)));
                command.Parameters.Add(new SqlParameter("@lav_quint", Convert.ToInt16(prio2)));
                command.Parameters.Add(new SqlParameter("@ban_dog", Convert.ToInt16(prio3)));
                command.Parameters.Add(new SqlParameter("@lav_gar", Convert.ToInt16(prio4)));
                command.Parameters.Add(new SqlParameter("@lic_filh", Convert.ToInt16(prio5)));
                command.Parameters.Add(new SqlParameter("@rep_ele", Convert.ToInt16(prio6)));
                command.Parameters.Add(new SqlParameter("@arr_cs", Convert.ToInt16(prio7)));
                command.Parameters.Add(new SqlParameter("@lav_car", Convert.ToInt16(prio8)));
                command.Parameters.Add(new SqlParameter("@refeicao", Convert.ToInt16(prio9)));
                command.Parameters.Add(new SqlParameter("@fz_cmp", Convert.ToInt16(prio10)));
                command.Parameters.Add(new SqlParameter("@rep_hid", Convert.ToInt16(prio11)));
                command.Parameters.Add(new SqlParameter("@bnh_fil", Convert.ToInt16(prio12)));
                
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");
                Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);

            }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            insere();
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

        private void ckbcs7_CheckedChanged(object sender, EventArgs e)
        {
            cmbprio7.Visible = true;
            prio7 = Convert.ToString(cmbprio7);
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

        public Casa()
        {
            InitializeComponent();
        }



        private void Casa_Load(object sender, EventArgs e)
        {

        }
    }
}
