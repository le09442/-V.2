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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string usernameS="siwadon", passwordS="0944200422";
        private void sogin1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void login1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `user` WHERE name= '" + username1.Text + "' and password	='" + password1.Text + "' ";
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show($"ยินดีต้อนรับคุณ{reader.GetString("name")} \nเข้าสู่ระบบของสายดึงดาวทุกท่าน");
                Form3 form3 = new Form3();
                usernameS = username1.Text;
                passwordS = password1.Text;
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("username หรือ password ไม่ถูกต้อง");
            }
        }
    }
}
