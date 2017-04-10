using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Orc : Monster
    {
        public Orc(string name, int health, int strength) : base(health, name, strength)
        {

        }

        public override void Battle(Creature opponent)
        {
            if (opponent.Strength > (this.Strength * 2))
            {
                this.Health = 0;
            }
            else
            {
                base.Battle(opponent);
            }
        }

    }
}
