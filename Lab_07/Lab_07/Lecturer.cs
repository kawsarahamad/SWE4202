using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Lecturer:Teacher
    {
        public string Teacher_type;

        public Lecturer(string Teacher_name,string Teacher_Contact_number,string Teacher_type):base( Teacher_name, Teacher_Contact_number)
        {
            this.Teacher_type = Teacher_type;
        }
        public double get_credit()
        {
            return 1.5;
        }
    }
}
