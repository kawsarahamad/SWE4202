using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        public string Car_Name;
        public string Car_Model;
        public int Number_of_cars;
        public Car(string Name, string Model, int Number_of_cars)
        {
            Car_Name = Name;
            Car_Model = Model;
            this.Number_of_cars = Number_of_cars;
        }
    }
}
