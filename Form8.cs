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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_5 = "SELECT * FROM `store` WHERE Products	='" + comboBox2.Text + "' ";
            MySqlConnection conn_5 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd_5 = new MySqlCommand(sql_5, conn_5);
            conn_5.Open();
            MySqlDataReader ค้นหา = cmd_5.ExecuteReader();
            if (ค้นหา.Read())
            {
                textBox2.Text = ค้นหา.GetString("name");
                richTextBox1.Text = ค้นหา.GetString("content");
            }
        }

        private void Form8_Shown(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string sql2 = "SELECT * FROM basket WHERE name='" + Form1.usernameS + "' and	สถานะ ='1' and คำสั่งซื้อจาก != 'ระบบ' ";
            MySqlConnection conn3 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox2.Items.Add($"{xxxx.GetString("buy")}");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }
    }
}
