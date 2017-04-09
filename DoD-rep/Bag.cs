using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Bag
    {
        //Behöver Bag vara en egen klass? Kan inte den vara en List<GameObjects>? eller List<Items>?
        public Bag()
        {

        }
        public Item Item { get; set; }
        public int TotalWeight { get; set ; } //Summan av alla upplockade items
    }
}
