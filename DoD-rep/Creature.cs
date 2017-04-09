using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    //TODO: Om man ska kunna ta upp monster och bära dom med sig kanske Weight ligga redan i GameObject?
    class Creature : GameObject
    {
        public Creature(string name, int health) : base (name)
        {
            Health = health;  
        }

        public int Health { get; set; }
    }
}
