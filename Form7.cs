using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace siwadon_5
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string sss_ = "s";
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                label5.Text = dataGridView2.Rows[e.RowIndex].Cells["buy"].FormattedValue.ToString();
                label13.Text = dataGridView2.Rows[e.RowIndex].Cells["คำสั่งซื้อจาก"].FormattedValue.ToString();
                label14.Text = dataGridView2.Rows[e.RowIndex].Cells["ราคา"].FormattedValue.ToString();
                label20.Text = dataGridView2.Rows[e.RowIndex].Cells["จำนวน"].FormattedValue.ToString();
                sss_ = dataGridView2.Rows[e.RowIndex].Cells["สถานะ"].FormattedValue.ToString();
                if (sss_ == "1")
                {
                    button16.Text = "พิมพ์ใบเสร๊จ";
                }
                else
                {
                    button16.Text = "ยืนยันคำสั่ง";
                }
            }
            catch
            {

            }
        }
        string comment_;
        private void _dataGridView2()
        {
            button1.Hide();
            comment_ = "SELECT buy,คำสั่งซื้อจาก,ราคา,จำนวน,สถานะ FROM basket WHERE name= '" + Form1.usernameS + "'";
            if (comboBox1.Text == "ทั้งหมด")
            {
                comment_ = "SELECT buy,คำสั่งซื้อจาก,ราคา,จำนวน,สถานะ FROM basket WHERE name= '" + Form1.usernameS + "'";
            }
            else if (comboBox1.Text == "จ่ายแล้ว")
            {
                comment_ = "SELECT buy,คำสั่งซื้อจาก,ราคา,จำนวน,สถานะ FROM basket WHERE name= '" + Form1.usernameS + "'and สถานะ=1";
            }
            else if (comboBox1.Text == "ยังไม่จ่าย")
            {
                button1.Show();
                comment_ = "SELECT buy,คำสั่งซื้อจาก,ราคา,จำนวน,สถานะ FROM basket WHERE name= '" + Form1.usernameS + "'and สถานะ=0";
            }
            else if (comboBox1.Text == "คำสั่งซื้อจากระบบ")
            {
                comment_ = "SELECT buy,คำสั่งซื้อจาก,ราคา,จำนวน,สถานะ FROM basket WHERE name= '" + Form1.usernameS + "'and คำสั่งซื้อจาก = 'ระบบ' ";
            }
            else if (comboBox1.Text == "คำสั่งซื้อจ่ายผู้ขาย")
            {
                comment_ = "SELECT buy,คำสั่งซื้อจาก,ราคา,จำนวน,สถานะ FROM basket WHERE name= '" + Form1.usernameS + "'and คำสั่งซื้อจาก != 'ระบบ' ";
            }




            label3.Text = Form1.usernameS;
            MySqlConnection conn_ = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            DataSet ds = new DataSet();
            conn_.Open();

            MySqlCommand cmd_;
            cmd_ = conn_.CreateCommand();
            cmd_.CommandText = comment_;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd_);
            adapter.Fill(ds);
            conn_.Close();
            dataGridView2.DataSource = ds.Tables[0]; 

        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            if (Form3.x == 1)
            {

            }
            else
            {
                comboBox1.Text = "ยังไม่จ่าย";
            }
            _dataGridView2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataGridView2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form3.x == 1)
            {

                new Form4().Show();
                this.Close();
            }
            if (Form3.x == 2)
            {

                new Form3().Show();
                this.Close();
            }
        }
        public static string usernameS, passwordS, buyS, a1, a2, a3;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sss_ == "0")
            {
                string conn_2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
                string sql_2 = "UPDATE basket SET สถานะ = '1' WHERE name= '" + Form1.usernameS + "' and buy	='" + label5.Text + "'" +
                    " and จำนวน	='" + label20.Text + "' and ราคา	='" + label14.Text + "'";
                MySqlConnection con_2 = new MySqlConnection(conn_2);
                MySqlCommand cmd_2 = new MySqlCommand(sql_2, con_2);
                con_2.Open();
                int rows_2 = cmd_2.ExecuteNonQuery();
                con_2.Close();
                _dataGridView2();
                //


                button16.Text = "พิมพ์ใบเสร๊จ";
                buyS = label5.Text;
                a1 = label13.Text;
                a2 = label14.Text;
                a3 = label20.Text;
                bill bill = new bill();
                bill.ShowDialog();








                //
            }
            else
            {
                buyS = label5.Text;
                a1 = label13.Text;
                a2 = label14.Text;
                a3 = label20.Text;
                bill bill = new bill();
                bill.ShowDialog();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sss_ == "1")
            {
                MessageBox.Show("การลบรายการที่กดยืนยันแล้วจะไม่มี ผลใดๆเป็นแค่การลบออกจากระบบ");
            }
            string sql6 = "SELECT * FROM `weed` WHERE name= '" + label5.Text + "'  ";
            MySqlConnection conn6 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd6 = new MySqlCommand(sql6, conn6);
            conn6.Open();
            MySqlDataReader reader6 = cmd6.ExecuteReader();
            if (reader6.Read())
            {

                int ssssssss = Convert.ToInt32(reader6.GetString("จำนวน")) + Convert.ToInt32(label20.Text);
                if (sss_ != "1")
                {

                    string sql_6 = "UPDATE weed SET จำนวน='" + ssssssss
                    + "' WHERE name= '" + label5.Text + "' ";
                    MySqlConnection con_6 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
                    MySqlCommand cmd_6 = new MySqlCommand(sql_6, con_6);
                    con_6.Open();
                    int rows_6 = cmd_6.ExecuteNonQuery();
                    con_6.Close();
                }



                string sql_1 = "DELETE FROM basket WHERE name= '" + Form1.usernameS + "' and buy	='" + label5.Text + "'";
                MySqlConnection con_1 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
                MySqlCommand cmd_1 = new MySqlCommand(sql_1, con_1);
                con_1.Open();
                int rows = cmd_1.ExecuteNonQuery();
                con_1.Close();
                _dataGridView2();
            }
            else
            {

                string sql_1 = "DELETE FROM basket WHERE name= '" + Form1.usernameS + "' and buy	='" + label5.Text + "'";
                MySqlConnection con_1 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
                MySqlCommand cmd_1 = new MySqlCommand(sql_1, con_1);
                con_1.Open();
                int rows = cmd_1.ExecuteNonQuery();
                con_1.Close();
                _dataGridView2();
            }
        }
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          

                e.Graphics.DrawString("ซูรูปรุง", new Font("TH SarabunPSK", 20, FontStyle.Bold), Brushes.Black, new Point(268, 40));
                e.Graphics.DrawString("วันที่   " + System.DateTime.Now.ToString("dd/MM/yyyy "), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(570, 128));
                e.Graphics.DrawString("เวลา   " + System.DateTime.Now.ToString("HH : mm : ss น."), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(571, 145));
                e.Graphics.DrawString("     หอ7 ห้องศิวดล", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 80));
                e.Graphics.DrawString("    เบอร์ติดต่อ 0944200422  ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 110));
                e.Graphics.DrawString("     พพ 0944200422", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 140));

                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 150));
                e.Graphics.DrawString("ชื่อสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(30, 170));
                e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(650, 170));
                e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(740, 170));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 200));
            string sql6 = "SELECT * FROM `basket` WHERE  name= '" + Form1.usernameS + "' and สถานะ ='0'   ";
            MySqlConnection conn6 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd6 = new MySqlCommand(sql6, conn6);
            conn6.Open();
            MySqlDataReader reader6 = cmd6.ExecuteReader();
            int y = 250,จำนวนน=0,ราคาา=0;
            while (reader6.Read())
            {
                e.Graphics.DrawString(reader6.GetString(2), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(30, y));
                e.Graphics.DrawString(reader6.GetString(6), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(650, y));
                e.Graphics.DrawString(reader6.GetString(5), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(740, y));
                y += 25;
                จำนวนน += reader6.GetInt32(6);
                ราคาา += reader6.GetInt32(5);
            }


                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, y + 20));
            e.Graphics.DrawString("รวมทั้งสิ้น    " + จำนวนน + "   รายการ", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, (y) + 45));
            e.Graphics.DrawString("จ่ายเงิน      " + ราคาา + "    บาท", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, ((y - 10) + 45) + 45));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, ((((y - 10) + 45) + 45) + 45) + 10));
            e.Graphics.DrawString(" ขอบคุณที่ใช้บริการครับผม 😊 😊 ", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(275, ((((y + 10) + 45) + 45) + 45) + 10));
            string conn_2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
            string sql_2 = "UPDATE basket SET สถานะ = '1' WHERE name= '" + Form1.usernameS + "'";
            MySqlConnection con_2 = new MySqlConnection(conn_2);
            MySqlCommand cmd_2 = new MySqlCommand(sql_2, con_2);
            con_2.Open();
            int rows_2 = cmd_2.ExecuteNonQuery();
            con_2.Close();
            _dataGridView2();

        }


    }
}
