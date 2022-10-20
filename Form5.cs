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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string coom = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
        private void dataGridView1__()
        {
            MySqlConnection conn_ = new MySqlConnection(coom);
            DataSet ds = new DataSet();
            conn_.Open();

            MySqlCommand cmd_;
            cmd_ = conn_.CreateCommand();
            cmd_.CommandText = "SELECT * FROM store WHERE name= '" + Form1.usernameS + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd_);
            adapter.Fill(ds);
            conn_.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            dataGridView1__();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                menu5.Text = dataGridView1.Rows[e.RowIndex].Cells["Products"].FormattedValue.ToString();
                label3.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            }
            catch
            {

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sto = "ลบ";
            wwwww = menu5.Text;
            new Form6().Show();
            this.Close();
        }
        public static string sto = "เพิ่ม",wwwww;
        private void button5_Click(object sender, EventArgs e)
        {
            sto = "เพิ่ม";
            wwwww = menu5.Text;
            new Form6().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sto = "อัปเดต";
            wwwww = menu5.Text;
            new Form6().Show();
            this.Close();
        }
    }
}
