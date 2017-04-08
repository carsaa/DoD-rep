using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Bag
    {
        public Bag()
        {

        }
        public Item Item { get; set; }
        public int TotalWeight { get; set ; } //Summan av alla upplockade items
    }
}
