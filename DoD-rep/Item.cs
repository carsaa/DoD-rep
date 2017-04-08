﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    abstract class Item : GameObject
    {
        public Item(string name, int weight) : base(name)
        {
            Weight = weight;
        }
        public int Weight { get; set; }

    }
}
