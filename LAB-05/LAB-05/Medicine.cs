using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    internal class Medicine
    {
        public string Type;
        public string Name;
        public string company_name;
        public int amount;
        public int price;
        public string expire_date;

        public Medicine(string Type, string Name, string company_name, int amount,int price,string expire_date)
        {
            this.Type = Type;
            this.Name = Name;
            this.company_name = company_name;
            this.amount = Convert.ToInt32(amount);
            this.price = Convert.ToInt32(price);
            this.expire_date = expire_date;
        }
       
    }
}
