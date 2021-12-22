using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Medicine> Medicine_list = new List<Medicine>();
        private void Add_Medicine_Onclick(object sender, EventArgs e)

        {
            Medicine new_medicine = new Medicine(textBox_type.Text, textBox_Name.Text, textBox_companyName.Text, Convert.ToInt32(textBox_amount.Text), Convert.ToInt32(textBox_Price.Text), textBox_expireDate.Text);
            Medicine_list.Add(new_medicine);
            comboBox_Name_sell.Items.Add(new_medicine.Name);
            comboBox_Name_show.Items.Add(new_medicine.Name);
            MessageBox.Show("You have added " + new_medicine.amount + " amount of" + new_medicine.Name + " medicine successfully.");
        }

        private void show_avaibality_onclick(object sender, EventArgs e)
        {
            foreach (Medicine new_med in Medicine_list)
            {
                if (comboBox_Name_show.Text== new_med.Name) {

                    Available_amount.Text = "Available Amount :" + new_med.amount.ToString();
                    Price.Text = "Price :    " + new_med.price.ToString();
                    Expire_Date.Text ="Expire date : "+new_med.expire_date.ToString();
                }
            }
        }
        Account current_Balance = new Account();

        private void sell_Onclick(object sender, EventArgs e)
        {
            foreach(Medicine sell_med in Medicine_list)
            {
                if(comboBox_Name_sell.Text== sell_med.Name)
                {
                    if (sell_med.amount >= Convert.ToInt32(textBox_amount_sell.Text))
                    {
                        sell_med.amount -= Convert.ToInt32(textBox_amount_sell.Text);
                        MessageBox.Show("You have sold " + textBox_amount_sell.Text + " " + comboBox_Name_sell.Text + " successfully.");
                        current_Balance.initial_Balance = current_Balance.initial_Balance+ (sell_med.amount*sell_med.price);
                    }
                    else MessageBox.Show(" We have only " + sell_med.amount.ToString() + " " + comboBox_Name_sell.Text);
                }

            }
        }

        private void showBalance_onclick(object sender, EventArgs e)
        {
            MessageBox.Show("Your current Balance is " + current_Balance.initial_Balance + " tk.");
        }
    }

}
