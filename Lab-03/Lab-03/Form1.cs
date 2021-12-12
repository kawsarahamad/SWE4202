using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Lab_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Car> CarList = new List<Car>();
        private void SaveCarOnClick(object sender, EventArgs e)
        {
            string Name = CarNametextBox.Text;
            string Model = CarModeltextBox.Text;
            int Number_of_cars = Convert.ToInt32(NumberofcarstextBox.Text);

            Car Dummy = new Car(Name, Model, Number_of_cars);
            CarList.Add(Dummy);
            MessageBox.Show("The car has been added succesfully");

        }



        private void ShowCarHistoryOnClick(object sender, EventArgs e)
        {

        }

        private void RentCarOnClick(object sender, EventArgs e)
        {

        }
        List<User> UserList = new List<User>();
        private void SaveUserOnClick_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDtextBox.Text);
            string name = UserNametextBox.Text;
            string address = UserAddresstextBox.Text;
            string destinattion = DestinationtextBox.Text;
            int Rental_Car = 0;
            User dummy = new User(id, name, address, destinattion,Rental_Car);
            UserList.Add(dummy);
            MessageBox.Show("The user has been added succesfully");
        }



        private void ShowUserHistory_Click_1(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(UserIDTexBox2.Text);
            bool flag = false;
            foreach (User User in UserList)
            {
                if (User.User_Id == Id)
                {
                    flag = true;
                    UserName.Text = "User Name" + ":" + User.User_Name;
                    Address.Text = "Address: " + User.User_Address;
                    Destination.Text = "Destination: " + User.User_Destination;
                    RentalCar.Text = "Rental Car :"+User.Rental_Car.ToString();
                }
            }
            if (flag == false)
            {
                MessageBox.Show("The user is not found");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = CarNametextBox2.Text;
            bool flag = false;
            foreach (Car Car in CarList)
            {
                if (Car.Car_Name == name)
                {
                    carModel.Text = "Car Model: " + Car.Car_Model;
                    AvailableUnit.Text="Available Unit: "+ Car.Number_of_cars.ToString();
                   

                }

            }
            if(flag == false)
            {
                MessageBox.Show("The Car is not found");
            }
        }

        private void rentaCarOnclick(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(UserIDtextBox3.Text);
            bool Flag_User = false;
            foreach(User user in UserList)
            {
                if(user.User_Id== Id)
                {
                    Flag_User = true;
                    user.Rental_Car =user.Rental_Car + 1;

                }

            }
            if( Flag_User == false)
            {
                MessageBox.Show("User is not found,Please add the user first");
            }
            string carName = CarNametextBox3.Text;
            bool Flag_Car = false;
            foreach (Car New_car in CarList)
            {  
               if((New_car.Car_Name == carName) && (New_car.Number_of_cars>0))
                {
                    Flag_Car = true;
                    New_car.Number_of_cars--;
                    MessageBox.Show("The Rent has been done succesfully");
                }
              
               
            }
            if(Flag_Car == false)
            {
                MessageBox.Show("The car is not available");
            }

        }

       
    }
}
