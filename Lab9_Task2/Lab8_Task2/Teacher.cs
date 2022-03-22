using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task2
{
    internal class Teacher:Staff
    {
        public string subject;
        public string publications;

        public Teacher showTecherInfo(Teacher t)
        {
            //Console.WriteLine(this.Name + "\n" + this.code + "\n" + this.subject + "\n" + this.publications + "\n");
            return t;
        }
    }
}
