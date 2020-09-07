using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Condition
    {
        public static void Start()
        {
            Resource.Fuel += 8;
            Resource.Food += 8;
            Resource.Water += 8;
            Resource.Gold += 0;

            Dialogue.Introduction();
            Game.Reset = true;
        }        

        public static void Defeat()
        {
            if (Resource.Fuel < 1 || Resource.Food < 1 || Resource.Water < 1)
            {
                Game.Reset = false;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Dialogue.PrintSpeed25ms("Uh oh, you don't have enough supplies to make this journey!\n");
                Console.ReadLine();
                Console.Clear();
                View.Over();
            }
        }  
        
        public static void Victory()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Dialogue.PrintSpeed25ms("Congratulations,\nYou just bought the pet rock!");
            Game.Reset = false;
            Dialogue.PressEnterPrompt();
            View.Victory();

        }

        public static void Exit()
        {
            Dialogue.PrintSpeed25ms("Take a break?\n[Y] Yes\n[N] No\n");
            char decision = Convert.ToChar(Console.ReadLine());
            if (decision == 'y' || decision == 'Y')
            {
                Console.Clear();
                Game.Reset = false;
            }
            else if (decision == 'n' || decision == 'N')
            {
                if (Game.Reset == true)
                {
                    Console.Clear();
                    View.Cockpit();
                }
                
            }
            else
            {
                Dialogue.InvalidEntry();
                Int16.Parse(Console.ReadLine());
            }
        }
    }       
}
