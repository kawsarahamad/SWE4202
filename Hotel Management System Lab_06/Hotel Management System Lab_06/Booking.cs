using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Lab_06
{
    internal class Booking
    {
        
        public string Room_name;
        public int Quantity;
        public string Entry_Date;
        public int Duration;
        public string Departure_Date;
        public string Booking_ID;
        public string Booking_status;
         public Booking( string Room_name, string Quantity, string Entry_Date, string Duration, string Departure_Date)
        {
            this.Room_name = Room_name;
            this.Quantity = Convert.ToInt32(Quantity);
            this.Entry_Date = Entry_Date;
            this.Duration = Convert.ToInt32(Duration);
            this.Departure_Date = Departure_Date;
        }
    }
}
