using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Pirates
    {
        public static void Plunder()
        {
            if (Resource.Fuel > 6 || Resource.Food > 6 || Resource.Water > 6 || Resource.Gold > 6)
            {          
                Random random = new Random();
                int plunder = 1;
                    int evasion = random.Next(8);
                if (evasion < plunder)
                    {
                        Console.Clear();
                        View.PiratesBoarding();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Dialogue.PrintSpeed25ms("Uh oh, you're being boarded by pirates!\n");
                    if (Resource.Fuel > 6) { Resource.Fuel /= 2; }
                    else if (Resource.Food > 6) { Resource.Food /= 2; }
                    else if (Resource.Water > 6) { Resource.Water /= 2; }
                    else if (Resource.Gold > 6) { Resource.Gold /= 2; }
                    Dialogue.PressEnterPrompt();
                    Console.Clear();
                    View.PiratesLeaving();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Dialogue.PrintSpeed25ms("'He he he, Looks that we be the holders o'these treasures!'\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Dialogue.PrintSpeed25ms($"You've been left with,\n ({Resource.Fuel}) FUEL\n ({Resource.Water}) WATER\n ({Resource.Food}) FOOD\n ({Resource.Gold}) GOLD\n\n");
                    Dialogue.PressEnterPrompt();
                }
            }
        }
    }
}
