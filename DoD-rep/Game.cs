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
        Random random = new Random(); //TODOD Göra en Random.Utils klass?
        Player player;
        Item item;
        Bag bag = new Bag();
        //int totalWeight = 0;

        public void Play()
        {
            CreateWorld();
            DisplayPlayStats();
            DisplayWorld(); //Måste den här verkligen stå här och i do-while loopen, räcker det inte om den står i loopern?
            DisplayBag();

            do
            {
                AskForMovement();
                Console.Clear();
                DisplayPlayStats();
                DisplayWorld();
                DisplayBag();
                CheckRoom();


            } while (player.Health > 0);
        }

        private void DisplayBag()
        {
            Console.Write($"Items in bag: ");

            foreach (var item in player.bag)
            {
                Console.Write($"{item.Name}, ");
            }
            Console.WriteLine();
        }

        private void CheckRoom()
        {
            Room currentRoom = world[player.X, player.Y];

            if (currentRoom.item is Food && currentRoom.item != null) //TODO!!! Varför???
            {
                Food food = currentRoom.item as Food; //TODO!!! Varför???

                player.Health += food.Health;
                currentRoom.item = null;
            }
            else if (currentRoom.item is Weapon && currentRoom.item != null)
            {
                player.bag.Add(currentRoom.item);
                bag.TotalWeight += currentRoom.item.Weight;
                currentRoom.item = null;
            }
            else if (currentRoom.monster != null)
            {
                Console.Write("Du har ett träffat på ett Monster! Buu! Vill du slåss mot det? (Y/N)");
                string fightMonster = Console.ReadLine();
                currentRoom.monster = null;
            }

        }

        private void DisplayPlayStats()
        {
            //TODOD: Man skulle kunna göra en klass där alla utskrifter sköts.
            Console.WriteLine($"Player: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Bag weight: {bag.TotalWeight}");
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

            if (isValidMove &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;

                player.Health--;
            }

        }

        private void DisplayWorld()
        {
            //Console.Clear();

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    if (player.X == x && player.Y == y) //Om positionen överensstämmer med spelaren så skriv ut spelarens namn
                    {
                        Console.Write(player.Name); //TODOD: Ska man skriva ut hela namnet eller bara initial( typ player.Name[0]) eller en ikon för spelaren?
                    }
                    else if (world[x, y].item is Food && world[x,y].item != null) //Annars om rummet inte är tomt så skriv Ä
                    {
                        Console.Write("Ä");
                    }
                    else if (world[x, y].item is Weapon && world[x, y].item != null) //Annars om rummet inte är tomt så skriv Ä
                    {
                        Console.Write("S");
                    }
                    else if (world[x, y].monster != null) //Annars om rummet inte är tomt så skriv Ä
                    {
                        Console.Write("M");
                    }
                    else //Skriv ut .
                    {
                        Console.Write(".");
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
                    world[x, y] = new Room(); //För varje "koordinat/ruta" i vår array skapar vi ett nytt rum
                    Room room = world[x, y]; //Rummet room = den där specifika rutan

                    if (random.Next(0, 101) < 10) //Om slumparen ger oss en siffra under 10 så får rummet ett item
                    {
                        if (random.Next(0, 2) == 0)
                        {
                            room.item = new Food("Ä", 1, 5);
                        }
                        else
                            room.item = new Weapon("S", 1);

                    }
                    else if (random.Next(0, 101) < 20)
                    {
                        room.monster = new Monster(50, "M");
                    }
                }
            }
        }
    }
}

