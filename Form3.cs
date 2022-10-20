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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string coom = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
        string[] weep = new string[7];
        int[] ราคา = new int[7];
        private void app()
        {
            string sql2_ = "SELECT * FROM weed";
            MySqlConnection conn2 = new MySqlConnection(coom);
            MySqlCommand cmd2 = new MySqlCommand(sql2_, conn2);
            conn2.Open();
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd2).Fill(dt);
            MySqlDataReader weep__ = cmd2.ExecuteReader();
            weep[0] = "s";
            ราคา[0] = 1;
            while (weep__.Read())
            {
                weep[Convert.ToInt32(weep__.GetString("id"))] = weep__.GetString("name");
                ราคา[Convert.ToInt32(weep__.GetString("id"))] = Convert.ToInt32(weep__.GetString("price"));
            }
        }
        string sql2;
        int num, max_ = 0, min_ = 0, num_ww = 1, sssss = 0, a_a = 0;
        string comma, content_ = "";
        int x_x;

        private void button1_Click(object sender, EventArgs e)
        {
            buy(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buy(1);
        }

        private void buy(int ss = 0)
        {

            id_panel1.Hide();
            id_panel2.Hide();
            id_panel3.Hide();
            id_panel4.Hide();
            id_panel5.Hide();

            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();



            MySqlConnection conn2_ = new MySqlConnection(coom);
            sql2 = "SELECT * FROM weed WHERE name ='" + menu.Text + "' ";
            MySqlCommand cmd2_ = new MySqlCommand(sql2, conn2_);
            conn2_.Open();
            DataTable dt_ = new DataTable();
            new MySqlDataAdapter(cmd2_).Fill(dt_);
            MySqlDataReader max_1 = cmd2_.ExecuteReader();
            if (max_1.Read())
            {
                try
                {
                    numericUpDown1.Maximum = Convert.ToInt32(max_1.GetString("จำนวน"));
                    numericUpDown1.Value = 1;
                }
                catch
                {
                    numericUpDown1.Maximum = 0;
                    numericUpDown1.Value = 0;
                }
            }


            sql2 = "SELECT * FROM store WHERE type ='" + menu.Text + "' ";
            if (ss == 1)
            {
                sql2 = "SELECT * FROM store WHERE type ='" + menu.Text + "' and id >'" + max_ + "' ";
                button1.Show();
                sssss += 1;

                //MessageBox.Show("SELECT * FROM store WHERE type ='" + menu.Text + "' and id >'" + max_ + "',,,'" + a_a + "' ");
            }
            if (ss == 2)
            {
                sql2 = "SELECT * FROM store WHERE type ='" + menu.Text + "' and id <'" + min_ + "'";
                button2.Show();
                sssss -= 1;
                a_a = 6 * sssss;

                //MessageBox.Show("SELECT * FROM store WHERE type ='" + menu.Text + "' and id <'" + min_ + "',,,'"+ a_a + "' ");

            }

            MySqlConnection conn2 = new MySqlConnection(coom);
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
            conn2.Open();
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd2).Fill(dt);
            MySqlDataReader ของซื้อของขาย = cmd2.ExecuteReader();
            num = dt.Rows.Count;
            if (num > 5)
            {
                button2.Show();
            }
            else if (num < 5)
            {
                button2.Hide();
            }
               

            if (sssss == 0)
            {
                button1.Hide();
            }


            while (ของซื้อของขาย.Read())
            {
                sql2 = "SELECT * FROM basket WHERE name='" + Form1.usernameS + "' and	buy ='" + ของซื้อของขาย.GetString(1) + "'";
                MySqlConnection conn3 = new MySqlConnection(coom);
                MySqlCommand cmd3 = new MySqlCommand(sql2, conn3);
                conn3.Open();
                DataTable dt3 = new DataTable();
                new MySqlDataAdapter(cmd3).Fill(dt3);
                MySqlDataReader ดูของ = cmd3.ExecuteReader();
                if (ดูของ.Read())
                {
                    x_x = 1;

                }

                if (num_ww == 1 + a_a)
                {
                    id_panel1.Show();
                    u_1.Text = ของซื้อของขาย.GetString(0);
                    p_1.Text = ของซื้อของขาย.GetString(1);
                    comma = ของซื้อของขาย.GetString(2);
                    for (int i = 0; i < 23; i++)
                    {
                        try
                        {
                            content_ = content_ + comma[i];
                        }
                        catch
                        {

                        }

                    }
                    content_ = content_ + "...";
                    c_1.Text = content_;
                    pr_1.Text = ของซื้อของขาย.GetString(3);
                    max_ = Convert.ToInt32(ของซื้อของขาย.GetString("id"));
                    min_ = Convert.ToInt32(ของซื้อของขาย.GetString("id"));
                    content_ = "";

                    if (x_x == 1)
                    {
                        label7.Show();
                    }




                }
                else if (num_ww == 2 + a_a)
                {

                    id_panel2.Show();
                    u_2.Text = ของซื้อของขาย.GetString(0);
                    p_2.Text = ของซื้อของขาย.GetString(1);
                    comma = ของซื้อของขาย.GetString(2);
                    for (int i = 0; i < 23; i++)
                    {
                        try
                        {
                            content_ = content_ + comma[i];
                        }
                        catch
                        {

                        }
                    }
                    content_ = content_ + "...";
                    c_2.Text = content_;

                    pr_2.Text = ของซื้อของขาย.GetString(3);
                    max_ = Convert.ToInt32(ของซื้อของขาย.GetString("id"));
                    //num_ww++;
                    content_ = "";

                    if (x_x == 1)
                    {
                        label8.Show();
                    }
                }
                else if (num_ww == 3 + a_a)
                {

                    id_panel3.Show();
                    u_3.Text = ของซื้อของขาย.GetString(0);
                    p_3.Text = ของซื้อของขาย.GetString(1);
                    comma = ของซื้อของขาย.GetString(2);
                    for (int i = 0; i < 23; i++)
                    {
                        try
                        {
                            content_ = content_ + comma[i];
                        }
                        catch
                        {

                        }
                    }
                    content_ = content_ + "...";
                    c_3.Text = content_;

                    pr_3.Text = ของซื้อของขาย.GetString(3);
                    max_ = Convert.ToInt32(ของซื้อของขาย.GetString("id"));
                    //num_ww++;
                    content_ = "";

                    if (x_x == 1)
                    {
                        label9.Show();
                    }
                }
                else if (num_ww == 4 + a_a)
                {

                    id_panel4.Show();
                    u_4.Text = ของซื้อของขาย.GetString(0);
                    p_4.Text = ของซื้อของขาย.GetString(1);
                    comma = ของซื้อของขาย.GetString(2);
                    for (int i = 0; i < 23; i++)
                    {
                        try
                        {
                            content_ = content_ + comma[i];
                        }
                        catch
                        {

                        }
                    }
                    content_ = content_ + "...";
                    c_2.Text = content_;

                    pr_4.Text = ของซื้อของขาย.GetString(3);
                    max_ = Convert.ToInt32(ของซื้อของขาย.GetString("id"));
                    //num_ww++;
                    content_ = "";

                    if (x_x == 1)
                    {
                        label10.Show();
                    }
                }
                else if (num_ww == 5 + a_a)
                {
                    id_panel5.Show();
                    u_5.Text = ของซื้อของขาย.GetString(0);
                    p_5.Text = ของซื้อของขาย.GetString(1);
                    comma = ของซื้อของขาย.GetString(2);
                    for (int i = 0; i < 23; i++)
                    {
                        try
                        {
                            content_ = content_ + comma[i];
                        }
                        catch
                        {

                        }
                    }
                    content_ = content_ + "...";
                    c_5.Text = content_;

                    pr_5.Text = ของซื้อของขาย.GetString(3);

                    max_ = Convert.ToInt32(ของซื้อของขาย.GetString("id"));
                    /*num_ww++*/
                    ;
                    content_ = "";

                    if (x_x == 1)
                    {
                        label11.Show();
                    }
                }
              num_ww++;
              x_x = 0;

            }
            num_ww = 1;
        }

        private void id_panel1_Click(object sender, EventArgs e)
        {
            app_menu(u_1.Text, p_1.Text, 1);
        }

        private void id_panel2_Click(object sender, EventArgs e)
        {
            app_menu(u_2.Text, p_2.Text, 2);
        }

        private void id_panel3_Click(object sender, EventArgs e)
        {
            app_menu(u_3.Text, p_3.Text, 3);
        }

        private void id_panel4_Click(object sender, EventArgs e)
        {
            app_menu(u_4.Text, p_4.Text, 4);
        }

        private void id_panel5_Click(object sender, EventArgs e)
        {
            app_menu(u_5.Text, p_5.Text, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `weed` WHERE name= '" + menu.Text + "'  ";
            MySqlConnection conn = new MySqlConnection(coom);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() && Convert.ToInt32(reader.GetString("จำนวน")) >= Convert.ToInt32(numericUpDown1.Value)
                && Convert.ToInt32(reader.GetString("จำนวน")) > 0)
            {

                string sql1 = "INSERT INTO basket (name,buy,สถานะ,คำสั่งซื้อจาก,ราคา,จำนวน,เวลา) VALUES" +
                    "('" + Form1.usernameS + "','" + menu.Text + "','0','ระบบ','" + Convert.ToInt32(reader.GetString("price"))*numericUpDown1.Value + "','" + numericUpDown1.Value + "','" + DateTime.Now.ToShortDateString() + "') ";
                MySqlConnection con1 = new MySqlConnection(coom);
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                con1.Open();
                int rows1 = cmd1.ExecuteNonQuery();
                con1.Close();

                int ss_ss = Convert.ToInt32(reader.GetString("จำนวน")) - Convert.ToInt32(numericUpDown1.Value);
                string sql2 = $"UPDATE `weed` SET `จำนวน` = {ss_ss} WHERE `weed`.`name` = '{menu.Text}' ";
                MySqlConnection con2 = new MySqlConnection(coom);
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                con2.Open();
                int rows2 = cmd2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("คำสั่งซื้อได้รับมายืนยัน");
                numericUpDown1.Value = 1;



            }
            else
            {
                MessageBox.Show("สินค้าหมด");
            }
        }
        public static int x = 2;
        private void button8_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = 2;
            new Form7().Show();
            this.Close();
        }

        private void id_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            buy();
        }

        private void id_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void app_menu(string name__, string products__, int x)
        {
            string sql2 = "SELECT * FROM `store` WHERE name= '" + name__ + "'and Products = '" + products__ + "' ";
            MySqlConnection conn2 = new MySqlConnection(coom);
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
            conn2.Open();
            MySqlDataReader r2 = cmd2.ExecuteReader();
            if (r2.Read())
            {
                string sql2_ = "SELECT * FROM `basket` WHERE name= '" + Form1.usernameS + "'and buy = '" + r2.GetString("Products") + "' ";
                MySqlConnection conn2_ = new MySqlConnection(coom);
                MySqlCommand cmd2_ = new MySqlCommand(sql2_, conn2_);
                conn2_.Open();
                MySqlDataReader r2_ = cmd2_.ExecuteReader();
                if (r2_.Read())
                {
                    MessageBox.Show("มีคำสั่งซื้อนี้แล้ว");
                }
                else
                {


                    string sql3 = "INSERT INTO basket (name,buy,สถานะ,คำสั่งซื้อจาก,ราคา,จำนวน,เวลา) VALUES" +
                    "('" + Form1.usernameS + "','" + r2.GetString("Products") + "','0','" + r2.GetString("name") + "','" + r2.GetString("price") + "','1','"+DateTime.Now.ToShortDateString()+"') ";
                    MySqlConnection con3 = new MySqlConnection(coom);
                    MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
                    con3.Open();
                    int rows3 = cmd3.ExecuteNonQuery();
                    con3.Close();
                    if (x == 1)
                    {
                        label7.Show();
                    }
                    if (x == 2)
                    {
                        label8.Show();
                    }
                    if (x == 3)
                    {
                        label9.Show();
                    }
                    if (x == 4)
                    {
                        label10.Show();
                    }
                    if (x == 5)
                    {
                        label11.Show();
                    }
                    MessageBox.Show("ซื้อสำเร็จ");
                }
               


            }
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            app();
        }
        int a = 1, b = 2, c = 3, d = 4, f = 5;

        private void button3_Click(object sender, EventArgs e)
        {
            a += 1;
            b += 1;
            c += 1;
            d += 1;
            f += 1;

            if (a == 7)
            {
                a = 1;
            }
            if (b == 7)
            {
                b = 1;
            }
            if (c == 7)
            {
                c = 1;
            }
            if (d == 7)
            {
                d = 1;
            }
            if (f == 7)
            {
                f = 1;
            }

            nemu1.Image = Image.FromFile("D:\\รูป\\a" + a + ".jpg");
            nemu2.Image = Image.FromFile("D:\\รูป\\a" + b + ".jpg");

            nemu3.Image = Image.FromFile("D:\\รูป\\a" + c + ".jpg");
            menu.Text = weep[c];
            label1.Text = $"{ราคา[c]}";
            nemu4.Image = Image.FromFile("D:\\รูป\\a" + d + ".jpg");
            nemu5.Image = Image.FromFile("D:\\รูป\\a" + f + ".jpg");

            num_ww = 1;
            a_a = 0;
            button1.Hide();
            buy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a -= 1;
            b -= 1;
            c -= 1;
            d -= 1;
            f -= 1;
            if (a == 0)
            {
                a = 6;
            }
            if (b == 0)
            {
                b = 6;
            }
            if (c == 0)
            {
                c = 6;
            }
            if (d == 0)
            {
                d = 6;
            }
            if (f == 0)
            {
                f = 6;
            }

            nemu1.Image = Image.FromFile("D:\\รูป\\a" + a + ".jpg");
            nemu2.Image = Image.FromFile("D:\\รูป\\a" + b + ".jpg");

            nemu3.Image = Image.FromFile("D:\\รูป\\a" + c + ".jpg");
            menu.Text = weep[c];
            label1.Text = $"{ราคา[c]}";
            nemu4.Image = Image.FromFile("D:\\รูป\\a" + d + ".jpg");
            nemu5.Image = Image.FromFile("D:\\รูป\\a" + f + ".jpg");

            num_ww = 1;
            a_a = 0;
            button1.Hide();

            buy();
        }
    }
}
