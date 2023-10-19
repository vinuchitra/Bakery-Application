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
    public partial class chocolate : Form
    {
        public chocolate()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainpage mp = new Mainpage();
            mp.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Aqua;
            radioButton2.ForeColor = System.Drawing.Color.BlueViolet;
            itemscmb.Items.Clear();
            itemscmb.Items.Add("Dairy Milk");
            itemscmb.Items.Add("Kitkat");
            itemscmb.Items.Add("Munch");
            itemscmb.Items.Add("Perk");
            itemscmb.Items.Add("Gems");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = System.Drawing.Color.Aqua;
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            itemscmb.Items.Clear();
            itemscmb.Items.Add("Bourbon");
            itemscmb.Items.Add("5050");
            itemscmb.Items.Add("Hide & Seek");
            itemscmb.Items.Add("Oreo");
            itemscmb.Items.Add("Milkbikis");
        }

        private void itemscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemscmb.SelectedItem.ToString() == "Dairy Milk")
            {
                txtprice.Text = "40";
            }
            else if (itemscmb.SelectedItem.ToString() == "Kitkat")
            {
                txtprice.Text = "50";
            }
            else if (itemscmb.SelectedItem.ToString() == "Munch")
            {
                txtprice.Text = "20";
            }
            else if (itemscmb.SelectedItem.ToString() == "Perk")
            {
                txtprice.Text = "20";
            }
            else if (itemscmb.SelectedItem.ToString() == "Gems")
            {
                txtprice.Text = "10";
            }
            else if (itemscmb.SelectedItem.ToString() == "Bourbon")
            {
                txtprice.Text = "45";
            }
            else if (itemscmb.SelectedItem.ToString() == "5050")
            {
                txtprice.Text = "20";
            }
            else if (itemscmb.SelectedItem.ToString() == "Hide & Seek")
            {
                txtprice.Text = "35";
            }
            else if (itemscmb.SelectedItem.ToString() == "Oreo")
            {
                txtprice.Text = "25";
            }
            else if (itemscmb.SelectedItem.ToString() == "Milkbikis")
            {
                txtprice.Text = "15";
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
            if (txtdis.Text.Length > 0)
            {
                txtnet.Text = (Convert.ToInt16(txtsub.Text) - Convert.ToInt16(txtdis.Text)).ToString();
            }
        }

        private void txtamtpaid_TextChanged(object sender, EventArgs e)
        {
            if (txtamtpaid.Text.Length > 0)
            {
                txtbal.Text = (Convert.ToInt16(txtnet.Text) - Convert.ToInt16(txtamtpaid.Text)).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
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
    }
}
