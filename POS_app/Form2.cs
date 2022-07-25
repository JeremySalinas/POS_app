using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl1.Show();
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl21.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userControl21.Hide();
        }
    }
}
