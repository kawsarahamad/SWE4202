using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task3
{
    internal class Lab
    {
        private string labName;
        private int labCapacity;
        
        public string getlabName()
        {
            return labName;
        }
        public int getlabCapacity()
        {
            return labCapacity;
        }
        public void setlabCapacity(int a)
        {
            this.labCapacity = a;
        }
        public void setlabName(string a)
        {
            this.labName =a;
        }
    }
}
