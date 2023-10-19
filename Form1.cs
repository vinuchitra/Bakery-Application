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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor=System.Drawing.Color.Aqua;
            radioButton2.ForeColor=System.Drawing.Color.BlueViolet;
            itemscmb.Items.Clear();
            itemscmb.Items.Add("Rasagula");
            itemscmb.Items.Add("Jaangiri");
            itemscmb.Items.Add("Mysore Laddu");
            itemscmb.Items.Add("Gulabjamun");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = System.Drawing.Color.Aqua;
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            itemscmb.Items.Clear();
            itemscmb.Items.Add("Black Forest");
            itemscmb.Items.Add("Red Velvet");
            itemscmb.Items.Add("White Forest");
            itemscmb.Items.Add("Blueberry");
        }

        private void itemscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemscmb.SelectedItem.ToString() == "Rasagula")
            {
                txtprice.Text = "15";
            }
           else if (itemscmb.SelectedItem.ToString() == "Jaangiri")
            { 
                txtprice.Text = "10"; 
            }
            else if (itemscmb.SelectedItem.ToString() == "Mysore Laddu")
            { 
                txtprice.Text = "12";
            }
            else if (itemscmb.SelectedItem.ToString() == "Gulabjamun")
            { 
                txtprice.Text = "15"; 
            }
            else if (itemscmb.SelectedItem.ToString() == "Black Forest")
            {
                txtprice.Text = "75"; 
            }
            else if (itemscmb.SelectedItem.ToString() == "Red Velvet")
            { 
                txtprice.Text = "85"; 
            }
            else if (itemscmb.SelectedItem.ToString() == "White Forest")
            { 
                txtprice.Text = "90"; 
            }
            else if (itemscmb.SelectedItem.ToString() == "Blueberry")
            { 
                txtprice.Text = "80";
            }
            else
            {
                txtprice.Text = "0";
            }
            txttotal.Text = "";
            txtqty.Text = "";
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text.Length > 0)
            {
                txttotal.Text = (Convert.ToInt16(txtprice.Text) * Convert.ToInt16(txtqty.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = itemscmb.SelectedItem.ToString();
            arr[1] = txtprice.Text;
            arr[2] = txtqty.Text;
            arr[3] = txttotal.Text;
            ListViewItem list = new ListViewItem(arr);
            listView1.Items.Add(list);
            txtsub.Text = (Convert.ToInt16(txtsub.Text) + Convert.ToInt16(txttotal.Text)).ToString();

        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            if(txtdis.Text.Length > 0)
            {
                txtnet.Text = (Convert.ToInt16(txtsub.Text) - Convert.ToInt16(txtdis.Text)).ToString();
            }
        }

        private void txtamtpaid_TextChanged(object sender, EventArgs e)
        {
            if(txtamtpaid.Text.Length>0)
            {
                txtbal.Text = (Convert.ToInt16(txtnet.Text) - Convert.ToInt16(txtamtpaid.Text)).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        txtsub.Text = (Convert.ToInt16(txtsub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                         
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainpage mp = new Mainpage();
            mp.Show();
            this.Hide();
        }

        private void txtsub_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
