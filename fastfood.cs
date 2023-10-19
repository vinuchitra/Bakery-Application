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
    public partial class fastfood : Form
    {
        public fastfood()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainpage mp = new Mainpage();
            mp.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Aquamarine;
            radioButton2.ForeColor = System.Drawing.Color.BurlyWood;
            itemscmb.Items.Clear();
            itemscmb.Items.Add("Pelpoori");
            itemscmb.Items.Add("Egg Noodles");
            itemscmb.Items.Add("Mushroom");
            itemscmb.Items.Add("Paani Poori");
            itemscmb.Items.Add("Samosa");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = System.Drawing.Color.BurlyWood;
            radioButton1.ForeColor = System.Drawing.Color.Aquamarine;
            itemscmb.Items.Clear();
            itemscmb.Items.Add("Orange");
            itemscmb.Items.Add("Apple");
            itemscmb.Items.Add("Muskmelon");
            itemscmb.Items.Add("Rosemilk");
        }

        private void itemscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemscmb.SelectedItem.ToString()=="Pelpoori")
            {
                txtprice.Text = "60";
            }
            else if(itemscmb.SelectedItem.ToString()=="Egg Noodles")
            {
                txtprice.Text = "60";
            }
            else if(itemscmb.SelectedItem.ToString()=="Mushroom")
            {
                txtprice.Text = "65";
            }
            else if (itemscmb.SelectedItem.ToString() == "Paani Poori")
            {
                txtprice.Text = "55";
            }
            else if (itemscmb.SelectedItem.ToString() == "Samosa")
            {
                txtprice.Text = "25";
            }
            else if (itemscmb.SelectedItem.ToString() == "Orange")
            {
                txtprice.Text = "65";
            }
            else if (itemscmb.SelectedItem.ToString() == "Apple")
            {
                txtprice.Text = "65";
            }
            else if (itemscmb.SelectedItem.ToString() == "Muskmelon")
            {
                txtprice.Text = "65";
            }
            else if (itemscmb.SelectedItem.ToString() == "Rosemilk")
            {
                txtprice.Text = "65";
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
