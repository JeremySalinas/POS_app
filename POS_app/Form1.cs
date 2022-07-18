using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace POS_app
{
    public partial class loginForm : Form
    {
        string ConnectionString = @"Data Source=192.168.14.22,1434\MSSQLSERVER; Initial Catalog=AdventureWorks2019; User ID = Oliver; Password = Welcome123; TrustServerCertificate=True";
        public loginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT* FROM Person.EmailAddress WHERE EmailAddress = '" + usernameBox.Text+"'", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        if (usernameBox.Text.Equals(dr["EmailAddress"].ToString()) && usernameBox.Text == passwordBox.Text)
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username/Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

                con.Close();

            }
        }
    }
}