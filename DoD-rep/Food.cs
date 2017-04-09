using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    //TODO: Borde inte healt ligga längre upp i hierkin? För monster och players har väl också weight?
    class Food: Item
    {
        public Food(string name, int weight, int health) :base (name,weight)
        {
            Health = health;
        }

        public int Health { get; set; }
    }
}
