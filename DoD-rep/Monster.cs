using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Monster : GameObject
    {
        public Monster(int health, string name) : base(name)
        {
            Health = health;
        }

        public int Health { get; set; }
    }
}
