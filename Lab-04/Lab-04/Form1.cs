using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RentOnclick(object sender, EventArgs e)
        {
            foreach (SingleRoom room_check in single_rooms)
            {
                if (comboBox_rent_roomName.Text == room_check.Name)
                {
                    if (Convert.ToInt32(Rent_QuantitytextBox.Text) <= room_check.Quantity)
                    {
                        room_check.Quantity -= Convert.ToInt32(Rent_QuantitytextBox.Text);

                        MessageBox.Show("You have rented " + Rent_QuantitytextBox.Text + " " + room_check.Name + " rooms successfully.");
                        return;
                    }
                    else MessageBox.Show("We are extremely sorry sir, " + Rent_QuantitytextBox.Text + " " + room_check.Name + " rooms are not available right now.Only "+room_check.Quantity+" rooms are available.");
                    return ;
                }

            }

            foreach (DoubleRoom room_check in double_rooms)
            {
                if (comboBox_rent_roomName.Text == room_check.Name)
                {
                    if(Convert.ToInt32(Rent_QuantitytextBox.Text)<= room_check.Quantity)
                    {
                        room_check.Quantity -= Convert.ToInt32(Rent_QuantitytextBox.Text);
                        MessageBox.Show("You have rented " + Rent_QuantitytextBox.Text + " " + room_check.Name + " rooms successfully.");
                        return;
                    }
                    else MessageBox.Show("We are extremely sorry sir, " + Rent_QuantitytextBox.Text + " " + room_check.Name + " rooms are not available right now.");

                }

            }
        }
        List<SingleRoom> single_rooms = new List<SingleRoom>();
        List<DoubleRoom> double_rooms = new List<DoubleRoom>();
        private void AddOnclick(object sender, EventArgs e)
        {
            
            SingleRoom dummy = new SingleRoom(roomNamecomboBox.Text,TVtextBox.Text,refrigeretortextBox.Text, BedtextBox.Text, singleQuantitytextBox.Text, AC_comboBox.Text,Gaming_setupcomboBox.Text);
            
            foreach (SingleRoom s_rooms in single_rooms)
            {
                if (s_rooms.Name == dummy.Name)
                {
                    
                    MessageBox.Show("You have added " + dummy.Quantity.ToString() + " " + dummy.Name.ToString() + " rooms successfully which cost " + dummy.Calculate_Cost() + " tk per day.");
                    s_rooms.Quantity +=dummy.Quantity;
                    return ;
                }

            }
            single_rooms.Add(dummy);
            comboBox_rent_roomName.Items.Add(dummy.Name);
            comboBox_show_roomName.Items.Add(dummy.Name);
            MessageBox.Show("You have added " + dummy.Quantity.ToString() + " " + dummy.Name.ToString()+" rooms successfully which cost " + dummy.Calculate_Cost() +" tk per day.");
        }

        private void Add_doubleOnclick(object sender, EventArgs e)
        {
            DoubleRoom double_rooms_01=new DoubleRoom(roomNamecomboBox1.Text, TVtextBox2.Text, textBox_Refrigeretor.Text, BedtextBox4.Text, textBox_doublRoom_qty.Text,ACcomboBox.Text,comboBox_extraTv.Text,comboBox_complimentoryBreakfast.Text);
            
            foreach (DoubleRoom d_rooms in double_rooms)
            {
                if (d_rooms.Name ==double_rooms_01.Name)
                { 
                    MessageBox.Show("You have added " + double_rooms_01.Quantity.ToString() + " " + double_rooms_01.Name.ToString() + " rooms successfully which cost " + double_rooms_01.Calculate_cost() + " tk per day.");
                    d_rooms.Quantity += double_rooms_01.Quantity;
                        return;
                }

            }
            double_rooms.Add(double_rooms_01);
            comboBox_rent_roomName.Items.Add(double_rooms_01.Name);
            comboBox_show_roomName.Items.Add(double_rooms_01.Name);
            
           
            
            MessageBox.Show("You have added " + double_rooms_01.Quantity.ToString() + " " + double_rooms_01.Name.ToString() + " rooms successfully which cost " + double_rooms_01.Calculate_cost()+" tk per day.");
        }

        private void Show_Avaibility_OnClick(object sender, EventArgs e)
        {
            foreach (SingleRoom room_check in single_rooms)
            {
                if (comboBox_show_roomName.Text == room_check.Name)
                {
                    if (room_check.Quantity > 0)
                    {

                        MessageBox.Show(room_check.Quantity.ToString() + " " + room_check.Name + (room_check.Quantity > 1 ? " rooms are available now." : " room is available."));
                    }
                    else MessageBox.Show("No " + room_check.Name + "is available now.");
                }


            }

            foreach (DoubleRoom room_check in double_rooms)
            {
                if (comboBox_show_roomName.Text == room_check.Name)
                {  if (room_check.Quantity > 0)
                    {

                        MessageBox.Show(room_check.Quantity.ToString() + " " + room_check.Name + (room_check.Quantity > 1 ? " rooms are available now." : " room is available."));
                    }
                    else MessageBox.Show("No " + room_check.Name + "is available now.");
                }

            }
        }
    }
}
