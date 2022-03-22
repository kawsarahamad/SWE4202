using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Employee_Management_System
{
    internal class Manager:Employee
    {
        public void setID(int num)
        {
            this.ID = Convert.ToString(num);
        }
        public override void calculateSalary(double amount,int days)
        {
            if (days / 365 >= 1)
            {
                salary = amount + amount * .15;
            }
            else
                salary = amount;
        }
    }
}
