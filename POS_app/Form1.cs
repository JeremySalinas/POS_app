using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace POS_app
{
    public partial class loginForm : Form
    {
        string ConnectionString = @"Microsoft SQL Server";
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
                            Form2 frm2 = new Form2();
                            frm2.Show();
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

        private void loginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
