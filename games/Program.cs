using System;
using System.Resources;

namespace Questtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your name, dragonborne?");
            string name = Console.ReadLine();
            Console.WriteLine("Your name " + name);
            bool goodgame = true;
            bool Key = false;
            bool screwdriver = false;

            bool axe = false;
            while (goodgame)
            {
                Console.WriteLine("Jange your way:");
                Console.WriteLine("1) Open the door");
                Console.WriteLine("2) look under bad");
                Console.WriteLine("3) open box in the corner of the room");
                Console.WriteLine("4) open the wentilation");
                Console.WriteLine("5) look at the night stand");
                Console.WriteLine("6) Look at the статуе near with door");
                Console.WriteLine("enter the nomber of your choise");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    if (Key == true)
                    {
                        Console.WriteLine(name + ", congratuations!");
                        Console.WriteLine("you have become a person, not a gamer!");
                        goodgame = false;
                    }
                    else
                    {
                        Console.WriteLine("Door is locked.");
                        Console.WriteLine("Try to find a key.");
                    }
                }
                else if (action == 2)
                {
                    Console.WriteLine("you don't see anythink");
                }
                else if (action == 3)
                {
                    Console.WriteLine("you found socks, but you don't need them");
                }
                else if (action == 4)
                {
                    if (screwdriver == false)
                    {
                        Console.WriteLine("It's locked. Try to find an screwdriver.");
                    }
                    else
                    {
                        Console.WriteLine("You find a key! Try to open the door");
                        Key = true;
                    }
                }
                else if (action == 5)
                {
                    Console.WriteLine("you find a Бублегуме");
                }
                else if (action == 6)
                {
                    Console.WriteLine("You find a ScrewDriver!");
                    screwdriver = true;
                }
                else
                {
                    Console.WriteLine("ALARME !!! ALARME !!! ALARME !!! WRONG NOMBER!!!");
                }
            }
        }
    }
}