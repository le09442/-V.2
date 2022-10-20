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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string coom = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
        private void button7_Click(object sender, EventArgs e)
        {
            string sql_ = "SELECT * FROM `store` WHERE name= '" + Form1.usernameS + "' and Products	='" + Products5.Text + "' ";
            MySqlConnection conn_ = new MySqlConnection(coom);
            MySqlCommand cmd_ = new MySqlCommand(sql_, conn_);
            conn_.Open();
            MySqlDataReader reader = cmd_.ExecuteReader();
            if (reader.Read() && reader.GetString("Products") == Products5.Text && button7.Text != "ลบ" && button7.Text != "อัปเดต")
            {
                MessageBox.Show("มีชื่อนี้อยู่ในระบบนะเจ้า");

            }

            else if (Products5.Text == "" || content5.Text == "" || price5.Text == "" || type5.Text == "")
            {
                MessageBox.Show("ใส่ให้คบทุกช่อง");

            }

            else if (button7.Text == "เพิ่ม")
            {

                string sql = "INSERT INTO store (name,Products,content,price,type) " +
                    "VALUES" +
                    "('" + Form1.usernameS
                    + "','" + Products5.Text + "','" + content5.Text + "','" + price5.Text + "','" + type5.Text + "') ";
                MySqlConnection con = new MySqlConnection(coom);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                new Form5().Show();
                this.Hide();
            }
            else if (button7.Text == "อัปเดต")
            {

                string sql = "UPDATE store SET  Products = '" + Products5.Text + "', content = '" + content5.Text + "', price = '" + price5.Text + "', type = '" + type5.Text + "' " +
                    "WHERE name= '" + Form1.usernameS + "' and Products	='" + Form5.wwwww + "' ";
                MySqlConnection con = new MySqlConnection(coom);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                new Form5().Show();
                this.Hide();
            }
            else if (button7.Text == "ลบ")
            {
                string sql = "DELETE FROM store WHERE name= '" + Form1.usernameS + "' and Products	='" + Form5.wwwww + "'";
                MySqlConnection con = new MySqlConnection(coom);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                new Form5().Show();
                this.Hide();
            }
        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            button7.Text = Form5.sto;
            if (button7.Text == "เพิ่ม")
            {

            }
            else if (button7.Text == "ลบ")
            {
                string sql = "SELECT * FROM `store` WHERE name= '" + Form1.usernameS + "' and Products	='" + Form5.wwwww + "' ";
                MySqlConnection conn = new MySqlConnection(coom);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Products5.Text = reader.GetString("Products");
                    content5.Text = reader.GetString("content");
                    price5.Text = reader.GetString("price");
                    type5.Text = reader.GetString("type");



                }
            }
            else if (button7.Text == "อัปเดต")
            {
                string sql = "SELECT * FROM `store` WHERE name= '" + Form1.usernameS + "' and Products	='" + Form5.wwwww + "' ";
                MySqlConnection conn = new MySqlConnection(coom);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Products5.Text = reader.GetString("Products");
                    content5.Text = reader.GetString("content");
                    price5.Text = reader.GetString("price");
                    type5.Text = reader.GetString("type");



                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Close();
        }

        private void Form6_StyleChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
