using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class TravelTo
    {
        public static (char, string) Venus(char locAb, string locName)
        {
            locName = "Venus";
            View.Venus();
            Destination.Features(locAb, locName);
            return (locAb, locName);
        }
        public static (char, string) Earth(char locAb, string locName)
        {
            locName += "Earth";
            View.Earth();
            Destination.Features(locAb, locName);
            return (locAb, locName);
        }
        public static (char, string) Lune(char locAb, string locName)
        {
            locName += "Lune";
            View.Lune();
            Destination.Features(locAb, locName);
            return (locAb, locName);
        }
        public static (char, string) Mars(char locAb, string locName)
        {
            locName += "Mars";
            View.Mars();
            Destination.Features(locAb, locName);
            return (locAb, locName);
        }
        public static (char, string) Europa(char locAb, string locName)
        {
            locName += "Europa";
            View.Europa();
            Destination.Features(locAb, locName);
            return (locAb, locName);

        }
        public static void CargoBay()
        {
            View.CargoBay();
            Condition.Exit();            
        }
    }
}

