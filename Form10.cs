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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void select_dataGridView3()
        {
            string comment_ = "SELECT * FROM `weed`";
            MySqlConnection conn_4 = new MySqlConnection(coom);
            DataSet ds4 = new DataSet();
            conn_4.Open();

            MySqlCommand cmd_4;
            cmd_4 = conn_4.CreateCommand();
            cmd_4.CommandText = comment_;

            MySqlDataAdapter abc4 = new MySqlDataAdapter(cmd_4);
            abc4.Fill(ds4);
            conn_4.Close();
            dataGridView3.DataSource = ds4.Tables[0]; ;
        }
        private void Form10_Shown(object sender, EventArgs e)
        {
            select_dataGridView3();
        }
        int p;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView3.CurrentRow.Selected = true;
                tx1.Text = dataGridView3.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                tx2.Text = dataGridView3.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                tx3.Text = dataGridView3.Rows[e.RowIndex].Cells["จำนวน"].FormattedValue.ToString();
                p = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            }
            catch
            {

            }
        }
        string coom = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_5;";
        private void button19_Click(object sender, EventArgs e)
        {
            string sql5 = "UPDATE weed SET  name = '" + tx1.Text + "', price = '" + tx2.Text + "', จำนวน = '" + tx3.Text + "' " +
                "WHERE id='" + p + "' ";
            MySqlConnection con5 = new MySqlConnection(coom);
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();
            int rows5 = cmd5.ExecuteNonQuery();
            con5.Close();
            select_dataGridView3();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
