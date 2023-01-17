using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POchTA
{
    class Valu
    {
        public string name { get; set; }
        public string name2 { get; set; }
        public double cost { get; set; }
       public bool dos { get; set; }
       

       public Valu(string na,string nam2, double co,bool w) {
            name = na;
            name2 = nam2;
            cost = co;
            dos = w;
        }
     
    }
}
