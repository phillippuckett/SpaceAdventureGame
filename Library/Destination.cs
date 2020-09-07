using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Destination
    {
        public static (char, string) Features(char locAb, string locName)
        {
            Resource.Attrition();
            View.Merchant();
            Dialogue.Merchant(locAb, locName);
            return (locAb, locName);
        }
        public static (char, string) Choices(char locAb, string locName)
        {
            Pirates.Plunder();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Dialogue.PrintSpeed25ms($"Where do you want to go?\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Dialogue.PrintSpeed10ms("[V] Venus  : Fuel Resupply\n[E] Earth  : Food Resupply\n[L] Lune   : The Lune Rune (a pet rock)\n[M] Mars   : Gold Exchange\n[A] Europa : Water Resupply\n[C] Cargo Bay\n");
            locAb = Convert.ToChar(Console.ReadLine());
                
            if (locAb == 'v' || locAb == 'V') { TravelTo.Venus(locAb, locName); }
            else if (locAb == 'e' || locAb == 'E') { TravelTo.Earth(locAb, locName); }
            else if (locAb == 'l' || locAb == 'L') { TravelTo.Lune(locAb, locName); }
            else if (locAb == 'm' || locAb == 'M') { TravelTo.Mars(locAb, locName); }
            else if (locAb == 'a' || locAb == 'A') { TravelTo.Europa(locAb, locName); }
            else if (locAb == 'c' || locAb == 'C') { TravelTo.CargoBay(); }
            else { Dialogue.InvalidEntry(); }

            return (locAb, locName); 
        }
    }
}