using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_Lab_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User new_user = new User(textBox_User_ID.Text, textBox_Name.Text, textBox_Contact_No.Text, textBox_Address.Text);
            Hotel_Management_System._Userlist.Add(new_user);
            MessageBox.Show("Your Account has been ctreated successfully.");
        }
        int Current_Ballance=0;
        private void Set_status_onClick(object sender, EventArgs e)
        {
            string booking_ID=textBox_Booking_ID.Text;
            foreach(Booking booking in Hotel_Management_System._Bookinglist)
            {
                if (booking_ID == booking.Booking_ID)
                {
                    booking.Booking_status = comboBox_set_status.Text;
                    MessageBox.Show("The Booking status has been set.");
                    if(booking.Booking_status == "Confirmed")
                    {
                        Current_Ballance += Total_Bill;
                        label19.Text="Current Ballance:" + Current_Ballance.ToString();
                    }

                }
            }
        }
        int Total_Bill;
        private void Placeorder_Onclick(object sender, EventArgs e)
        {
          Booking new_Booking = new Booking(comboBox_Room_choice.Text,textBox_Quantity.Text,textBox_Entry_Date.Text,textBox_Duration.Text,textBox_Departure_Date.Text);
           
          string ID_check = textBox_User_ID_02.Text;
          bool flag=false;
          foreach(User user in Hotel_Management_System._Userlist)
            {
                if (ID_check == user.User_ID)
                {
                    flag = true;
                    new_Booking.Booking_ID = user.User_ID;
                    new_Booking.Booking_status = "Pending";
                    // Hotel_Management_System._Bookinglist.Add(new_Booking.Booking_ID);
                    Hotel_Management_System._Bookinglist.Add(new_Booking);
                    Total_Bill = 0;
                    Total_Bill = new_Booking.Room_name == "Single Bed" ? Total_Bill += (new_Booking.Quantity * 1200*new_Booking.Duration) : Total_Bill += (new_Booking.Quantity * 1800 * new_Booking.Duration);
                    MessageBox.Show("Your Booking is pending now.Your Booking ID is "+user.User_ID.ToString() + " you have to pay "+Total_Bill.ToString());

                }
            }
          if (flag==false)
            {
                MessageBox.Show("The User ID is not found. Please create an account first.");
            }
        }

        private void See_order_Details_Onclick(object sender, EventArgs e)
        {
            string check_Booking_ID=textBox_Booking_ID_02.Text;
            bool check=false;
            foreach(Booking check_booking in Hotel_Management_System._Bookinglist)
            {
                if (check_Booking_ID == check_booking.Booking_ID)
                {
                    check = true;
                    Amount.Text= "Amount: "+Total_Bill.ToString();
                    status.Text = "status: " + check_booking.Booking_status;

                }
            }
            if (check == false)
            {
                MessageBox.Show("Booking ID is not found.");
            }
        }
    }
}
