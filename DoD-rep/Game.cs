using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoD_rep
{
    class Game
    {
        Room[,] world = new Room[20, 10];
        Player player;

        public void Play()
        {
            CreateWorld();

            do
            {
                DisplayWorld();
                AskForMovement();
               

            } while (player.PlayerHealth > 0);
        }

        private void AskForMovement()
        {
            ConsoleKeyInfo consoleKey = new ConsoleKeyInfo();
            int newX = 0;
            int newY = 0;

            switch (consoleKey.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                    
            }
        }

        private void DisplayWorld()
        {
            Console.Clear();

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    if (x != 0 || y != 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(player.PlayerName);
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private void CreateWorld()
        {
            player = new Player("P", 100, 0, 0);

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();
                }
            }
        }
    }
}

