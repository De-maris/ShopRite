using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopRite
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Clear();
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // what to do:check login username & password
            this.Hide();
            Dashboard1 main = new Dashboard1();
            main.Show();
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 main = new Form1();
            main.Show();
        }
    }
}
