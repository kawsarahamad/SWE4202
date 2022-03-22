using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Employee_Management_System
{
    internal class Employee
    {
        public string Name,ID,Designation,Contact,Date_of_joining;
        public double salary, Leaves;
        
        public virtual void calculateSalary(double amount,int days) { }
       
    }
}
