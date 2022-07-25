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
using POS_app;

namespace POS_app
{
    public partial class UserControl2 : UserControl
    {
        public static string[] name3 = new string[1000];
        public static int[] amount3 = new int[1000];
        public static double[] price3 = new double[1000];
        public static int y = 0;
        public static double sum = 0;

        public UserControl2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            while(y < UserControl1.j)
            {

                dataGridView1.Rows.Add(new object[] { name3[y], amount3[y], price3[y] });
                sum += (amount3[y] * price3[y]);
                y++;
            }
            sum = Math.Round(sum, 2);
            string totalPriceNum = sum.ToString();
            totalPrice.Text = "$"+totalPriceNum;

            if(y > 0)
            {
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Array.Clear(name3, 0, name3.Length);
                Array.Clear(amount3, 0, amount3.Length);
                Array.Clear(price3, 0, price3.Length);
                y = 0;
                UserControl1.j = 0;
                sum = 0;
                totalPrice.Text = "$0";
                dataGridView1.Rows.Clear();
                button2.Visible = false;
        }
    }
}
