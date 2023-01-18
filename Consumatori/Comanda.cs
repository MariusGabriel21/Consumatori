using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumatori
{
    class Comanda
    {
        public int comandaID { get; set; }
        public string Consumator { get; set; }
        public List<Articole> Articole { get; set; }
        public decimal TotalCost { get; set; }
       

        public override string ToString()
        {
            return comandaID + "\t" + Consumator + "\t" + TotalCost.ToString();
        } 

    }
}
