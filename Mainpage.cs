using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shinee_Bakes_App
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 sweet = new Form1();
            sweet.Show();
            this.Hide();
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 sweet = new Form1();
            sweet.Show();
            this.Hide();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            chocolate dm = new chocolate();
            dm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chips pot = new chips();
            pot.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fastfood pan = new fastfood();
            pan.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
