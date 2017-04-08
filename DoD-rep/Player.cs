using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Player : Creature
    {
        public Player(string name, int health, int x, int y) : base (name, health)
        {
            X = x;
            Y = y;
            bag = new List<Item>();
        }

        public int X { get; set; }
        public int Y { get; set; }
        public List<Item> bag { get; set; }
    }
}
