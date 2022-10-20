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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
        
        private void Form9_monts()
        {
            if (comboBox1.Text != "")
            {
                monts = comboBox1.Text;
            }
            if (comboBox2.Text != "")
            {
                monts = comboBox2.Text + "/" + comboBox1.Text;
            }
            if ( comboBox3.Text != "")
            {
                monts = comboBox3.Text + "/" + comboBox2.Text + "/" + comboBox1.Text;
            }
            Form9_cooo();




        }
        string sql, monts,monts_2;

        private void Form9_cooo()
        {
            if (Form1.usernameS != "siwadon")
            {
                sql = "SELECT name as'ผู้ซื้อ',buy,จำนวน,ราคา,เวลา FROM basket WHERE 	buy= '" + ssssss + "' and คำสั่งซื้อจาก='" + Form1.usernameS + "' and สถานะ != 0 and " +
                    "เวลา like '" + "%" + monts + "' and name like '"+ textBox1.Text +"%"+"'";
                if (ssssss == "ทั้งหมด")
                {
                    sql = "SELECT name as'ผู้ซื้อ',buy,จำนวน,ราคา,เวลา FROM basket WHERE คำสั่งซื้อจาก='" + Form1.usernameS + "' and สถานะ != 0 and เวลา like '" + "%" + monts + "' " +
                        "and name like '" + textBox1.Text + "%" + "'";
                }
            }
            if (Form1.usernameS == "siwadon")
            {
                sql = "SELECT name as'ผู้ซื้อ',buy,จำนวน,ราคา,เวลา FROM basket WHERE 	buy= '" + ssssss + "'  and สถานะ != 0 and " +
                    "เวลา like '" + "%" + monts + "' and name like '" + textBox1.Text + "%" + "'";
                if (ssssss == "ทั้งหมด")
                {
                    sql = "SELECT name as'ผู้ซื้อ',buy,จำนวน,ราคา,เวลา FROM basket WHERE สถานะ != 0 and เวลา like '" + "%" + monts + "' and name like '" + textBox1.Text + "%" + "'";
                }
            }
                MySqlConnection conn_ = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            DataSet ds = new DataSet();
            conn_.Open();

            MySqlCommand cmd_;
            cmd_ = conn_.CreateCommand();
            cmd_.CommandText = sql;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd_);
            adapter.Fill(ds);
            conn_.Close();
            dataGridView2.DataSource = ds.Tables[0];


            
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            int x = 0, y = 0;
            
            while (reader.Read())
            {
                x += reader.GetInt32(2);
                y += reader.GetInt32(3);
                
            }
            label20.Text = $"{x}";
            label14.Text = $"{y}";




        }
        private void Form9_GM()
        {

            comboBox4.Items.Clear();
            comboBox4.Items.Add("ทั้งหมด");
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM weed", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                comboBox4.Items.Add(reader.GetString(0));

            }
            conn.Close();
            conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            cmd = new MySqlCommand("SELECT Products FROM store ", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                comboBox4.Items.Add(reader.GetString(0));

            }
            conn.Close();
            ssssss = comboBox4.Text;
            

        }
        private void Form9_Shown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int x = 2560;
            int s_1 = Convert.ToInt32(System.DateTime.Now.ToString("yyyy"))-x;
            for (int i = 0; i <= s_1; i++)
            {
                comboBox1.Items.Add(x+i);
            }
            sql = "SELECT Products FROM store WHERE name= '" + Form1.usernameS + "'";
            comboBox4.Items.Clear();
            comboBox4.Items.Add("ทั้งหมด");
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox4.Items.Add(reader.GetString(0));

            }
            comboBox2.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            ssssss = comboBox4.Text;
            Form9_cooo(); 
            if (Form1.usernameS == "siwadon")
            {
                Form9_GM();
                button2.Show();
            }
            else
            {
                button2.Hide();
            }


        }
        string ssssss;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Close();
        }

       

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssssss = comboBox4.Text;
            Form9_cooo();
        }
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            int x = 0;
            if (comboBox2.Text == "1" || comboBox2.Text == "3"||comboBox2.Text == "5" || 
                comboBox2.Text == "7" || comboBox2.Text == "8" || comboBox2.Text == "10" ||
                comboBox2.Text == "12")
            {
                x = 31;
            }
            else if(comboBox2.Text == "4"|| comboBox2.Text == "6" || comboBox2.Text == "9" ||
                comboBox2.Text == "11")
            {
                x = 30;
            }
            else if (comboBox2.Text == "2")
            {
                x = 28;
            }
            comboBox3.Items.Add("");
            for (int i = 1; i <= x; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
            
            Form9_monts();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form9_cooo();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form10().Show();
            this.Close();
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form9_cooo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            comboBox2.Text = "";
            
            Form9_monts();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form9_monts();
        }
    }
}
