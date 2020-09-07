using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class Dialogue
    {
        public static void Introduction()
        {
            View.TitleScreen();
            PressEnterPrompt();
            View.CargoBay();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            PrintSpeed50ms("Congratulations sailor,\nYou've been assigned by ISS to retrieve a worthless rock from the moon.");
            Console.ReadLine();
            PrintSpeed25ms("   Best part is that it's just a pet rock - just like any paste-eyed rock you'd find on Earth...");
            Console.ReadLine();
            PrintSpeed25ms("      Oh, also its going to cost you (15) Gold, as well as (1) Fuel, (1) Water, and (1) Food for every trip you take.");
            Console.ReadLine();
            PrintSpeed50ms("        Not to mention space pirates...");
            Console.ReadLine();
            PrintSpeed25ms("           Anyway, good luck, don't get yourself killed by running out of supplies!\n");
            PressEnterPrompt();
            View.Cockpit();
        }


        public static void Merchant(char locAb, string locName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintSpeed25ms($"\nAhoy there wanderer, welcome to {locName}!\nWhat can I do ya for?\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[T] Trade\n[L] Leave\n");
            char decision = Convert.ToChar(Console.ReadLine());

            //[T] TRADE//
            if (decision == 't' || decision == 'T')
            {
                Console.Clear();
                string acquisition = Convert.ToString(decision);
                if (locAb == 'v' || locAb == 'V')
                {
                    //FUEL//
                    View.Venus();
                    Resource.Fuel += 5;
                    Console.ForegroundColor = ConsoleColor.White;
                    acquisition = "*You've received (4) FUEL.\n";
                }
                else if (locAb == 'e' || locAb == 'E')
                {
                    //FOOD//
                    View.Earth();
                    Resource.Food += 5;
                    Console.ForegroundColor = ConsoleColor.White;
                    acquisition = "*You've received (4) FOOD.\n";
                }
                else if (locAb == 'l' || locAb == 'L')
                {
                    //ROCK//
                    View.Lune();
                    if (Resource.Gold >= 15)
                    {
                        Resource.Rock += 1;
                        Console.ForegroundColor = ConsoleColor.White;
                        acquisition = "*You now have the Lunar Rune!\n";
                        Condition.Victory();
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        acquisition = "Gee-garsh-golly,\nBy the look of it ya don't have enough GOLD for a pet rock...";
                    }
                }
                else if (locAb == 'm' || locAb == 'M')
                {
                    //GOLD//
                    View.Mars();
                    Resource.Gold += 3;
                    Resource.Fuel -= 1;
                    Resource.Food -= 1;
                    Resource.Water -= 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    acquisition = "*You've received (3) GOLD\n*(-1) Fuel\n*(-1) Food\n*(-1) Water.\n";
                }
                else if (locAb == 'a' || locAb == 'A')
                {
                    //WATER//
                    View.Europa();
                    Resource.Water += 5;
                    acquisition = "*You've received (4) WATER.\n";
                }

                View.Merchant();
                Console.ForegroundColor = ConsoleColor.White;
                PrintSpeed25ms($"{acquisition}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintSpeed25ms($"Well so long partner, safe travels!\n");

                Console.ReadLine();
                View.Cockpit();
            }

            //[L] LEAVE//
            else if (decision == 'l' || decision == 'L')
            {
                if (locAb == 'v' || locAb == 'V') { View.Venus(); }
                else if (locAb == 'e' || locAb == 'E') { View.Earth(); }
                else if (locAb == 'l' || locAb == 'L') { View.Lune(); }
                else if (locAb == 'm' || locAb == 'M') { View.Mars(); }
                else if (locAb == 'a' || locAb == 'A') { View.Europa(); }
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintSpeed25ms("Well so long partner, safe travels!\n");
                Console.ReadLine();
                Console.Clear();
                View.Cockpit();
            }
            else
            {
                Dialogue.InvalidEntry();
                Convert.ToChar(Console.ReadLine());
            }
        }

        public static string PrintSpeed10ms(string @string)
        {
            foreach (char @char in @string)
            {
                Console.Write(@char);
                Thread.Sleep(10);
            };
            return @string;
        }

        public static string PrintSpeed25ms(string @string)
        {
            foreach (char @char in @string)
            {
                Console.Write(@char);
                Thread.Sleep(25);
            };
            return @string;
        }

        public static string PrintSpeed50ms(string @string)
        {
            foreach (char @char in @string)
            {
                Console.Write(@char);
                Thread.Sleep(25);
            };
            return @string;
        }





        //    public string splitString(string str) 
        //{ 
        //    StringBuilder alpha = new StringBuilder(); 
        //    StringBuilder num = new StringBuilder(); 
        //    StringBuilder special = new StringBuilder(); 

        //    for (int i = 0; i < str.Length; i++) 
        //    { 
        //        if (Char.IsDigit(str[i])) num.Append(str[i]); 

        //        else if((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z')) alpha.Append(str[i]); 

        //        else
        //            special.Append(str[i]); 
        //    } 

        //    return alpha, num, special; 
        //} 





        //public string PrintSpeed50ms(string @string)
        //{
        //    string[] @chars = new string[@string];
        //    for (int i = 0; i < @chars.Length; i++)
        //    {
        //        Thread.Sleep(50);
        //    }  
        //    return @string;
        //}

        public static void PressEnterPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n                                                PRESS [ENTER] TO CONTINUE");
            Console.ReadLine();
        }

        //INVALID USER ENTRY//
        public static void InvalidEntry()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintSpeed25ms("Not a valid entry, Press [ENTER] to try again. \n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
