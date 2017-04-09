using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    //TODOD: Borde inte spelare (och kanske monster) ha en styrka? Den borde i så fall kanske ligga i Creature, eller t om i GameObjects om vapen också ska ha styrka?
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
