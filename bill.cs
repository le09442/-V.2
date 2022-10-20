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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Creat2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bill_Shown(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM `user` WHERE name= '" + Form1.usernameS + "' and password	='" + Form1.passwordS + "'";
            MySqlConnection conn3 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            if (xxxx.Read())
            {
                label6.Text= xxxx.GetString("name");
                label7.Text = xxxx.GetString("phonenumber");
                label9.Text = xxxx.GetString("appress");
                
                
            }
            l1.Text = Form7.buyS;
            l2.Text = Form7.a1;
            l3.Text = Form7.a2;
            l4.Text = Form7.a3;
            int sss = Convert.ToInt32(l3.Text) * Convert.ToInt32(l4.Text);
            l5.Text = $"{sss}";
            if (l2.Text!="ระบบ")
            {
                label9.Text = "ไปยังคลัง";

            }

            sql2 = "SELECT * FROM `user` WHERE name	='" + l2.Text + "'";
            conn3 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            xxxx = cmd4.ExecuteReader();
            if (xxxx.Read())
            {
                label5.Text = xxxx.GetString("phonenumber");
                
            }
            else
            {
               
                    label5.Text = "0944200422";
                
            }
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }
    }
}
