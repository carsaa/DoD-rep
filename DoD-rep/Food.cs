using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Food: Item
    {
        public Food(string name, int weight, int health) :base (name,weight)
        {
            Health = health;
        }

        public int Health { get; set; }
    }
}
