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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void Dashboard1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_category pro = new Manage_category();  
            pro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewCategory main = new AddNewCategory();
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewBrand main = new AddNewBrand();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNewProducts main = new AddNewProducts();
            main.Show();
        }
    }
}
