using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace belt
{
    public partial class Form1 : Form
    {
        Random chislo = new Random();
        decimal z;
        int i = 0, j = 0, s10,k=0,q=0;
        decimal deltasidma_f_n, deltasigma_f0, CL, C1, C3, pois;
        decimal N, V, F, sigma_f_0, sigma_f, Z, S10, SIGMA_F, DEL_SIG_F, DEL_SIG_n, DP1 = 100;

        decimal[,] param = new decimal[5, 17];
        string[] param_w = { "Z", "F", "N", "V", "S10", "SIGMA_F", "DEL_SIG_F", "DEL_SIG_ n", "DP1", "C1", "C3", "CL" };
        DataTable tabel1;
        void Final_count()
        {

            F_();
            Delta();
            ploshad();//s10

            SF0();  //
            C_1();  //c1
            C_3();  //c3          
            C_L();  //CL
            Fdeltasidma_f_n();//
            Fdeltasigma_f0();//
            DEL_SIG_F = deltasigma_f0;
            DEL_SIG_n = deltasidma_f_n;
            S10 = s10;
            sigma_f = (sigma_f_0 + DEL_SIG_F) * C1 * C3 * CL;
            Z = 10 * F / (s10 * sigma_f * 10);
            SIGMA_F = decimal.Round(sigma_f, 2);
            F = decimal.Round(F, 2);
            if (F == 0)
                F = 1;
            z = Z;
            Z = decimal.Round(z);
            if (Z == 0)
                Z = 1;


        }

        void C_0()
        {

        }

        void InitTabel()
        {
            tabel1 = new DataTable();


            DataColumn x = tabel1.Columns.Add("№", typeof(Decimal));
            DataColumn x1 = tabel1.Columns.Add("Z", typeof(Decimal));
            DataColumn x2 = tabel1.Columns.Add("F", typeof(Decimal));
            DataColumn x3 = tabel1.Columns.Add("N", typeof(Decimal));
            DataColumn x4 = tabel1.Columns.Add("v", typeof(Decimal));
            DataColumn x5 = tabel1.Columns.Add("S10", typeof(Decimal));
            DataColumn x6 = tabel1.Columns.Add("SIGMA_F", typeof(Decimal));
            DataColumn x7 = tabel1.Columns.Add("DEL_SIG_F", typeof(Decimal));
            DataColumn x8 = tabel1.Columns.Add("DEL_SIG_n", typeof(Decimal));
            DataColumn x9 = tabel1.Columns.Add("DP1", typeof(Decimal));
            DataColumn x10 = tabel1.Columns.Add("C1", typeof(Decimal));
            DataColumn x11 = tabel1.Columns.Add("CL", typeof(Decimal));
            DataColumn x12 = tabel1.Columns.Add("C3", typeof(Decimal));


            DataRow y = tabel1.NewRow();
            DataRow y0 = tabel1.NewRow();
            DataRow y1 = tabel1.NewRow();
            DataRow y2 = tabel1.NewRow();
            DataRow y3 = tabel1.NewRow();
            DataRow y4 = tabel1.NewRow();
            DataRow y5 = tabel1.NewRow();
            DataRow y6 = tabel1.NewRow();
            tabel1.Rows.Add(y);
            tabel1.Rows.Add(y0);
            tabel1.Rows.Add(y1);
            tabel1.Rows.Add(y2);
            tabel1.Rows.Add(y3);
            tabel1.Rows.Add(y4);
            tabel1.Rows.Add(y5);
            tabel1.Rows.Add(y6);


            tabel1.Rows[0][0] = 1;
            tabel1.Rows[1][0] = 2;
            tabel1.Rows[2][0] = 3;
            tabel1.Rows[3][0] = 4;
            tabel1.Rows[4][0] = 5;
         
            dataGridView1.DataSource = tabel1;

        }

        void param_fill()
        {
            param[i, 0] = Z;
            param[i, 1] = F;
            param[i, 2] = N;
            param[i, 3] = V;
            param[i, 4] = S10;
            param[i, 5] = SIGMA_F;
            param[i, 6] = DEL_SIG_F;
            param[i, 7] = DEL_SIG_n;
            param[i, 8] = DP1;
            param[i, 9] = C1;
            param[i, 10] = CL;
            param[i, 11] = C3;


        }

        void ploshad()
        {

            if (radioButton21.Checked)
                s10 = 60;
            if (radioButton20.Checked)
                s10 = 330;
        }

        void Fdeltasidma_f_n()
        {
            if (radioButton21.Checked)
            {
                if (radioButton23.Checked)
                    deltasidma_f_n = 0.05m;
                if (radioButton22.Checked)
                    deltasidma_f_n = 0.13m;
                if (radioButton19.Checked)
                    deltasidma_f_n = 0.17m;
                if (radioButton18.Checked)
                    deltasidma_f_n = 0.24m;
            }
            else
            {
                if (radioButton23.Checked)
                    deltasidma_f_n = 0.06m;
                if (radioButton22.Checked)
                    deltasidma_f_n = 0.18m;
                if (radioButton19.Checked)
                    deltasidma_f_n = 0.28m;
                if (radioButton18.Checked)
                    deltasidma_f_n = 0.35m;

            }
            DEL_SIG_n = deltasidma_f_n;
        }
        void SF0()
        {
            if (radioButton21.Checked)
            {
                if (V <= 5)
                    sigma_f_0 = 7.48m;
                if (V <= 10)
                    sigma_f_0 = 6.80m;
                if (V <= 15)
                    sigma_f_0 = 6.35m;
                if (V <= 20)
                    sigma_f_0 = 5.86m;
                if (V <= 25)
                    sigma_f_0 = 5.45m;
                if (V <= 30)
                    sigma_f_0 = 4.93m;
            }
            else
            {
                if (V <= 5)
                    sigma_f_0 = 3.09m;
                if (V <= 10)
                    sigma_f_0 = 2.66m;
                if (V <= 15)
                    sigma_f_0 = 2.31m;
                if (V <= 20)
                    sigma_f_0 = 1.97m;
                if (V <= 25)
                    sigma_f_0 = 1.91m;
                if (V <= 30)
                    sigma_f_0 = 0.1m;
            }
        }
        void Fdeltasigma_f0()
        {
            deltasigma_f0 = (100 * deltasidma_f_n) / 100;
        }

        void C_L()
        {


            if (radioButton21.Checked)
            {
                if (radioButton27.Checked)
                    CL = 1.0m;
                if (radioButton26.Checked)
                    CL = 1.05m;
                if (radioButton25.Checked)
                    CL = 1.10m;
                if (radioButton24.Checked)
                    CL = 1.15m;
                if (radioButton29.Checked)
                    CL = 1.20m;
                if (radioButton28.Checked)
                    CL = 1.25m;
            }
            else
            {
                if (radioButton35.Checked)
                    CL = 1.0m;
                if (radioButton34.Checked)
                    CL = 1.05m;
                if (radioButton33.Checked)
                    CL = 1.10m;
                if (radioButton32.Checked)
                    CL = 1.15m;
                if (radioButton31.Checked)
                    CL = 1.20m;
                if (radioButton30.Checked)
                    CL = 1.25m;
            }
        }


        void C_1()
        {
            if (trackBar1.Value >= 70)
                C1 = 0.56m;
            if (trackBar1.Value >= 80)
                C1 = 0.62m;
            if (trackBar1.Value >= 90)
                C1 = 0.68m;
            if (trackBar1.Value >= 100)
                C1 = 0.74m;
            if (trackBar1.Value >= 110)
                C1 = 0.79m;
            if (trackBar1.Value >= 120)
                C1 = 0.83m;
            if (trackBar1.Value >= 130)
                C1 = 0.87m;
            if (trackBar1.Value >= 140)
                C1 = 0.90m;
            if (trackBar1.Value >= 150)
                C1 = 0.93m;
            if (trackBar1.Value >= 160)
                C1 = 0.96m;
            if (trackBar1.Value >= 170)
                C1 = 0.98m;
            if (trackBar1.Value == 180)
                C1 = 1.0m;

        }

        void C_3()
        {
            if (radioButton10.Checked)
                C3 = 1.0m;
            if (radioButton11.Checked)
                C3 = 0.9m;
            if (radioButton12.Checked)
                C3 = 0.9m;
            if (radioButton13.Checked)
                C3 = 0.8m;
            if (radioButton14.Checked)
                C3 = 0.8m;
            if (radioButton15.Checked)
                C3 = 0.7m;
            if (radioButton16.Checked)
                C3 = 0.7m;
            if (radioButton17.Checked)
                C3 = 0.5m;
        }

     

        void param_ch()
        {
            string q = listBox1.Text;
            for (int j = 0; j < 11; j++)
            {
                if (param_w[j] == q)
                    k = j;
            }
        }

        void chistka()//очистить выборку
        {
            param_ch();
            int n = i;
            for (int q = 0; q < 5; q++)
                dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.White;
            
        }
        void less()//меньше
        {
            param_ch();
            decimal number = Convert.ToDecimal(poiskaa_m.Text);
            int n = i;
            for (int q = 0; q < 5; q++)
                dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.White;
            for (int q = 0; q < n; q++)
            {
                if (param[q, k] < number)
                    dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        void more()//больше
        {
            param_ch();
            decimal number = Convert.ToDecimal(poiskaa_m.Text);
            int n = i;
            for (int q = 0; q < 5; q++)
                dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.White;
            for (int q = 0; q < n; q++)
            {
                if (param[q, k] > number)
                    dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        void equal()//равно
        {
            param_ch();
            decimal number = Convert.ToDecimal(poiskaa_m.Text);
            int n = i;
            for (int q = 0; q < 5; q++)
                dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.White;
            for (int q = 0; q < n; q++)
            {
                if (param[q, k] == number)
                    dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        void less_or_equal()//меньшеравно
        {
            param_ch();
            decimal number = Convert.ToDecimal(poiskaa_m.Text);
            int n = i;
            for (int q = 0; q < 5; q++)
                dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.White;
            for (int q = 0; q < n; q++)
            {
                if (param[q, k] <= number)
                    dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        void more_or_equal()//большеравно
        {
            param_ch();
            decimal number = Convert.ToDecimal(poiskaa_m.Text);
            int n = i;
            for (int q = 0; q < 5; q++)
                dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.White;
            for (int q = 0; q < n; q++)
            {
                if (param[q, k] >= number)
                    dataGridView1.Rows[q].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        void Delta()
        {
            N = Convert.ToDecimal(Moshnost_znachenie.Text);
            V = Convert.ToDecimal(Speed_znachenie.Text);

        }
        void F_()
        {

            V = Convert.ToDecimal(Speed_znachenie.Text);
            F = N / V;
            F = F * 1000;
        }

        void dobav()
        {
            for (j = 1; j <= 11; j++)
            {

                tabel1.Rows[i][j] = param[i, j - 1];
            }
            tabel1.Rows[i][12] = param[i, 11];


        }

        void Save_fail()
        {
            System.IO.Stream myStream;
            SaveFileDialog saveTags = new SaveFileDialog();
            saveTags.Filter = "All file (*.*) | *.*| Text file |*.txt";
            saveTags.FilterIndex = 2;

            if (saveTags.ShowDialog() == DialogResult.OK)

            {
                if ((myStream = saveTags.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(myStream, System.Text.Encoding.Default);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                if ((dataGridView1.ColumnCount - j) != 1) myWriter.Write(":");
                            }

                            if (((dataGridView1.RowCount - 1) - i - 1) != 0) myWriter.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWriter.Close();
                    }
                }
                myStream.Close();
            }
        }
      
        void udal()
        {

            if (i > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                i--;
            }


            
            
            
        }

            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTabel();
        }

        private void moshnost_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Moshnost_znachenie_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void Shkiv_Click(object sender, EventArgs e)
        {

        }

        private void Shkiv_znachenie_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_remnua_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Угол обхвата = " + trackBar1.Value;
            //C_1();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
           
            trackBar1.Visible = true;
            groupBox3.Visible = true;
            groupBox6.Visible = true;
            groupBox5.Visible = true;
            groupBox7.Visible = false;
            label1.Visible = true;

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            label1.Visible = true;
            groupBox3.Visible = true;
            trackBar1.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = false;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Speed_znachenie_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udal();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Save_fail();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void poiskaa_m_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
                less();
            if (radioButton6.Checked)
                more();
            if(radioButton5.Checked)
                equal();
            if (radioButton4.Checked)
                less_or_equal();
            if (radioButton1.Checked)
                more_or_equal();




        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            chistka();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Final_count();
            
            if (i <= 4)
            {
                param_fill();
                dobav();
                if (i == 4)
                    button1.Enabled = false;
                i++;
            }
            listBox1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            poiskaa_m.Visible = true;
            groupBox1.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
          
            groupBox3.Visible = true;
            trackBar1.Visible = true;
            label1.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            trackBar1.Visible = true;
            label1.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
          
            groupBox3.Visible = true;
            trackBar1.Visible = true;
            label1.Visible = true;
        }

       

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            groupBox3.Visible = true;
            trackBar1.Visible = true;
            label1.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 1.0m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }
      
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.9m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.9m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.8m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.8m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.7m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.7m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            //C3 = 0.6m;
            //label6.Text = Convert.ToString(C3);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }
    }
}
