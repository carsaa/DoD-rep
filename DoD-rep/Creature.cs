using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
   
    class Creature : GameObject
    {
        public Creature(string name, int health, int strength) : base (name)
        {
            Health = health;
            Strength = strength;
        }

        public int Health { get; set; }
        public int Strength { get; set; }

        public  virtual void Battle(Creature opponent)
        {
            opponent.Health -= this.Strength;
        }
    }
}
