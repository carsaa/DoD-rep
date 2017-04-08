using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Player
    {
        public Player(string playerName, int playerHealth, int x, int y)
        {
            PlayerName = playerName;
            PlayerHealth = playerHealth;
            X = x;
            Y = y;
            bag = new List<Item>();
        }

        public string PlayerName { get; set; }
        public int PlayerHealth { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Item> bag { get; set; }
    }
}
