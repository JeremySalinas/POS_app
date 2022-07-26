using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_app
{


    public partial class UserControl1 : UserControl
    {
        public static int j = 0;

        string ConnectionString = @"Microsoft SQL Server";
        public UserControl1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (DataTable dt = new DataTable("Products"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT [ProductID],[Name],[ProductNumber],[ListPrice] FROM [Production].[Product] WHERE ListPrice>0 AND Name LIKE '%" + searchProducts.Text + "%'", con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            selected.Text = dataGridView1.Rows[current].Cells[1].Value.ToString();
            priceBox.Text = dataGridView1.Rows[current].Cells[3].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            UserControl2.name3[j] = selected.Text;
            UserControl2.amount3[j] = Convert.ToInt32(comboBox1.Text);
            UserControl2.price3[j] = (double)decimal.Parse(priceBox.Text); ;
            j++;
        }
    }
}
