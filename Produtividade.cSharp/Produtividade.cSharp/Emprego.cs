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
    public partial class Emprego : Form
    {


    

        public bool logado = false;
        private Conecta conn;
        public int x = 0;
        public static SqlConnection ConnectOpen;

        public string prio1 = "", prio2 = "", prio3 = "", prio4 = "", prio5 = "", prio6 = "", prio7 = "", prio8 = "", prio9 = "", prio10 = "", prio11 = "", prio12 = "";

        public void combo1()
        {
            if (ckbcs1.Checked == true)
            {
                if (cmbQntPrio1.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }

            if (ckbcs1.Checked == false)
            {
                if (cmbQntPrio1.Text == "10" || cmbQntPrio1.Text == "7" || cmbQntPrio1.Text == "5" || cmbQntPrio1.Text == "3" || cmbQntPrio1.Text == "1")

                {
                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }


        }


        public void combo2()
        {
            if (ckbcs2.Checked == true)
            {
                if (cmbprio2.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs2.Checked == false)
            {
                if (cmbprio2.Text == "10" || cmbprio2.Text == "7" || cmbprio2.Text == "5" || cmbprio2.Text == "3" || cmbprio2.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo3()
        {
            if (ckbcs3.Checked == true)
            {
                if (cmbprio3.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs3.Checked == false)
            {
                if (cmbprio3.Text == "10" || cmbprio3.Text == "7" || cmbprio3.Text == "5" || cmbprio3.Text == "3" || cmbprio3.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo4()
        {
            if (ckbcs4.Checked == true)
            {
                if (cmbprio4.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs4.Checked == false)
            {
                if (cmbprio4.Text == "10" || cmbprio4.Text == "7" || cmbprio4.Text == "5" || cmbprio4.Text == "3" || cmbprio4.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo5()
        {
            if (ckbcs5.Checked == true)
            {
                if (cmbprio5.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs5.Checked == false)
            {
                if (cmbprio5.Text == "10" || cmbprio5.Text == "7" || cmbprio5.Text == "5" || cmbprio5.Text == "3" || cmbprio5.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo6()
        {
            if (ckbcs6.Checked == true)
            {
                if (cmbprio6.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs6.Checked == false)
            {
                if (cmbprio6.Text == "10" || cmbprio6.Text == "7" || cmbprio6.Text == "5" || cmbprio6.Text == "3" || cmbprio6.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo8()
        {
            if (ckbcs8.Checked == true)
            {
                if (cmbprio8.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs8.Checked == false)
            {
                if (cmbprio8.Text == "10" || cmbprio8.Text == "7" || cmbprio8.Text == "5" || cmbprio8.Text == "3" || cmbprio8.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo7()
        {
            if (ckbcs7.Checked == true)
            {
                if (cmbprio7.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs7.Checked == false)
            {
                if (cmbprio7.Text == "10" || cmbprio7.Text == "7" || cmbprio7.Text == "5" || cmbprio7.Text == "3" || cmbprio7.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo11()
        {
            if (ckbcs11.Checked == true)
            {
                if (cmbprio11.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs11.Checked == false)
            {
                if (cmbprio11.Text == "10" || cmbprio11.Text == "7" || cmbprio11.Text == "5" || cmbprio11.Text == "3" || cmbprio11.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo9()
        {
            if (ckbcs9.Checked == true)
            {
                if (cmbprio9.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs9.Checked == false)
            {
                if (cmbprio9.Text == "10" || cmbprio9.Text == "7" || cmbprio9.Text == "5" || cmbprio9.Text == "3" || cmbprio9.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }

        public void combo10()
        {
            if (ckbcs10.Checked == true)
            {
                if (cmbprio10.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs10.Checked == false)
            {
                if (cmbprio10.Text == "10" || cmbprio10.Text == "7" || cmbprio10.Text == "5" || cmbprio10.Text == "3" || cmbprio10.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }
        }

        public void combo12()
        {
            if (ckbcs12.Checked == true)
            {
                if (cmbprio12.Text == "")
                {
                    MessageBox.Show("Verifique prioridade");
                    x = 1;
                }


            }
            if (ckbcs12.Checked == false)
            {
                if (cmbprio12.Text == "10" || cmbprio12.Text == "7" || cmbprio12.Text == "5" || cmbprio12.Text == "3" || cmbprio12.Text == "1")
                {

                    MessageBox.Show("Verifique o que marcou");
                    x = 1;
                }

            }




        }
        private void cmbprio4_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio4 = cmbprio4.Text;
        }

        private void cmbprio5_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio5 = cmbprio5.Text;
        }

        private void cmbprio6_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio6 = cmbprio6.Text;
        }

        private void cmbprio7_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio7 = cmbprio7.Text;
        }

        private void cmbprio8_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio8 = cmbprio8.Text;
        }

        private void cmbprio9_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio9 = cmbprio9.Text;
        }

        private void cmbprio10_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio10 = cmbprio10.Text;
        }

        private void ckbcs1_CheckedChanged(object sender, EventArgs e)
        {
            prio1 = cmbQntPrio1.Text;
        }

        private void cmbprio11_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio11 = cmbprio11.Text;
        }

        private void cmbprio3_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio3 = cmbprio3.Text;


        }

        private void cmbprio2_SelectedIndexChanged(object sender, EventArgs e)
        {

            prio2 = cmbprio2.Text;
        }

        private void cmbQntPrio1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio1 = cmbQntPrio1.Text;



        }

        private void cmbprio12_SelectedIndexChanged(object sender, EventArgs e)
        {
            prio12 = cmbprio12.Text;
        }

        DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

        public void zerado()
        {
            if (prio1 == "" && prio2 == "" && prio3 == "" && prio4 == "" && prio5 == "" && prio6 == "" && prio7 == "" && prio8 == "" && prio9 == "" && prio10 == "" && prio11 == "" && prio12 == "")
            {
                MessageBox.Show("Selecione algo por favor ");
                x = 1;
            }

        }


        public void insere()
        {


            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Emprego(id, ver_ema, tr_dia, chk_ant, reunioes, inven, rel_consu, contra, avl_desm, rel_pag, pln_quin, real_ped, esc_func )");
            sql.Append("Values (@id, @ver_ema,  @tr_dia, @chk_ant, @reunioes, @inven, @rel_consu, @contra, @avl_desm, @rel_pag, @pln_quin, @real_ped, @esc_func )");
            SqlCommand command = null;



            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@id", locaDate));
                command.Parameters.Add(new SqlParameter("@ver_ema", Convert.ToInt16(prio1)));
                command.Parameters.Add(new SqlParameter("@tr_dia", Convert.ToInt16(prio2)));
                command.Parameters.Add(new SqlParameter("@chk_ant", Convert.ToInt16(prio3)));
                command.Parameters.Add(new SqlParameter("@reunioes", Convert.ToInt16(prio4)));
                command.Parameters.Add(new SqlParameter("@inven", Convert.ToInt16(prio5)));
                command.Parameters.Add(new SqlParameter("@rel_consu", Convert.ToInt16(prio6)));
                command.Parameters.Add(new SqlParameter("@contra", Convert.ToInt16(prio7)));
                command.Parameters.Add(new SqlParameter("@avl_desm", Convert.ToInt16(prio8)));
                command.Parameters.Add(new SqlParameter("@rel_pag", Convert.ToInt16(prio9)));
                command.Parameters.Add(new SqlParameter("@pln_quin", Convert.ToInt16(prio10)));
                command.Parameters.Add(new SqlParameter("@real_ped", Convert.ToInt16(prio11)));
                command.Parameters.Add(new SqlParameter("@esc_func", Convert.ToInt16(prio12)));


                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");
                Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);

            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            combo1();
            combo2();
            combo3();
            combo4();
            combo5();
            combo6();
            combo7();
            combo8();
            combo9();
            combo10();
            combo11();
            combo12();
          //  zerado();
            if (x == 0)
            {
                insere();
            }


        }
        public Emprego()
        {
            InitializeComponent();
            conn = new Conecta();
            ConnectOpen = conn.ConnectToDatabase();
        }

      


        private void Emprego_Load(object sender, EventArgs e)
        {

        }
    }
}
