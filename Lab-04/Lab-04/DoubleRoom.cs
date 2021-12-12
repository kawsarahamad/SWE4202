using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class DoubleRoom : Room
    {
        public bool Extra_TV;
        public bool complimentory_Breakfast;
        public DoubleRoom(string Name, string TV, string Refigeretor, string Bed, string Quantity, string Airconditionar, string Extra_TV, string complimentory_Breakfast) : base(Name, TV, Refigeretor, Bed, Quantity, Airconditionar)
        {
            this.Extra_TV = Extra_TV == "Yes" ? true : false;
            this.complimentory_Breakfast = complimentory_Breakfast == "Yes"?true:false;
        }
        public int Calculate_cost()
        {
            return 3500 + (Airconditionar ? 500 : 0) + (Extra_TV ? 1000 : 0) + (complimentory_Breakfast ? 1000 : 0);
        }
        
    }
}
