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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username2.Text == "" || emailw.Text == "" || password2.Text == "" || Appress2.Text == "")
            {
                MessageBox.Show("กรอบให้คบทุกช่อง");
            }
            else if (Phone_numcer2.Text.Length != 10)
            {
                MessageBox.Show("เบอร์ให้คบ10ตัว");
            }
            else if (password2.Text != VerifyPassword2.Text)
            {
                MessageBox.Show("รหัสไมม่ตรงกัน");

            }
            else if (!(email2.Text.Contains("@gmail.com") || email2.Text.Contains("@kkumail.com")))
            {
                MessageBox.Show("ใช้ @gmail.com||@kkumail.com");
            }
            else
            {
                string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
                string sql = "INSERT INTO user (name,password,phonenumber,appress,email) VALUES" +
                    "('" + username2.Text + "','" + password2.Text + "','" + Phone_numcer2.Text + "','" + Appress2.Text + "','" + emailw.Text + "') ";
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("สมัครสำเร็จ");
                    new Form1().Show();
                    this.Hide();
                }
            }

        }

        private void Phone_numcer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
