using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Classes
{
    public class Car
    {
        public string Owner { get; set; }
        public string Reg_num { get; set; } 
        public int Distance { get; set; }

        public Car(string own = "", string reg = "", int dist = 0)
        {
            Owner = own;
            Reg_num = reg;
            Distance = dist;
        }
    }
}
