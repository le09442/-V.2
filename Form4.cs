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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Phone_numcer4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        string com = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
        private void Form4_Shown(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `user` WHERE name= '" + Form1.usernameS + "' and password	='" + Form1.passwordS + "' ";
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                email4.Text = reader.GetString("email");
                password4.Text = reader.GetString("password");
                Appress4.Text = reader.GetString("appress");
                username4.Text = reader.GetString("name");
                Phone_numcer4.Text = reader.GetString("phonenumber");



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username4.Text == "" || email4.Text == "" || password4.Text == "" || Appress4.Text == "")
            {
                MessageBox.Show("กรอบให้คบทุกช่อง");
            }
            else if (Phone_numcer4.Text.Length != 10)
            {
                MessageBox.Show("เบอร์10ตัว");
            }
            else if (!(email4.Text.Contains("@gmail.com") || email4.Text.Contains("@kkumail.com")))
            {
                MessageBox.Show("ใช้ @gmail.com||@kkumail.com");
            }
            else
            {

                string sql = "UPDATE user SET name = '" + username4.Text + "', password =" +
                    " '" + password4.Text + "', phonenumber = '" + Phone_numcer4.Text + "', appress = '" + Appress4.Text + "', email = '" + email4.Text + "' WHERE name= '" + Form1.usernameS + "' and password	='" + Form1.passwordS + "';";
                MySqlConnection con = new MySqlConnection(com);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ทำรายการสำเร็จ");

                sql = "UPDATE basket SET name = '" + username4.Text + "'WHERE name= '" + Form1.usernameS + "';";
                con = new MySqlConnection(com);
                cmd = new MySqlCommand(sql, con);
                con.Open();
                rows = cmd.ExecuteNonQuery();
                con.Close();

                sql = "UPDATE store SET name = '" + username4.Text + "'WHERE name= '" + Form1.usernameS + "';";
                con = new MySqlConnection(com);
                cmd = new MySqlCommand(sql, con);
                con.Open();
                rows = cmd.ExecuteNonQuery();
                con.Close();

                Form1.usernameS=username4.Text;
                Form1.passwordS=password4.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3.x = 1;
            new Form7().Show();
            this.Close();
        }

        private void Phone_numcer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
