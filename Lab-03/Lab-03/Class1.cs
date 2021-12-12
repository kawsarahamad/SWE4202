using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class User
    {
        public int User_Id;
        public string User_Name;
        public string User_Address;
        public string User_Destination;
        public int Rental_Car;
        public User(int Id, string Name, string Address, string Destination, int Rental_Car)
        {
            User_Id = Id;
            User_Name = Name;
            User_Address = Address;
            User_Destination = Destination;
            this.Rental_Car = Rental_Car;

        }

    }
   
}
