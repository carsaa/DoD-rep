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
                Console.Clear();
                DisplayWorld();
                AskForMovement();
               

            } while (player.PlayerHealth > 0);
        }

        private void AskForMovement()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            int newX = player.X;
            int newY = player.Y;

            bool isValidMove = true;
       
            switch (consoleKey.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidMove = false; break;
            }

            if(isValidMove && 
                newX >=0 && newX < world.GetLength(0) && 
                newY  >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }            

        }

        private void DisplayWorld()
        {
            //Console.Clear();

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    if (player.X != x || player.Y != y )
                    {
                        Console.Write(".");
                    }
                    else if (player.X == x && player.Y == y)
                    {
                        Console.Write(player.PlayerName);
                    }
                }
                Console.WriteLine();
            }
        }

        private void CreateWorld()
        {
            player = new Player("P", 100, 5, 5);

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

