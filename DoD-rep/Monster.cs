﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    abstract class Monster : Creature
    {
        public Monster(int health, string name, int strength) : base(name, health, strength)
        {
        }
    }
}
