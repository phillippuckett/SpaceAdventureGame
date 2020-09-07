using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Game
    {
        public static void Loop()
        {
            Condition.Start();
            while (Reset)
            {
                Destination.Choices(LocAb, LocName);               
                Condition.Defeat();
            }          
        }
        public static bool Reset { get; set; }
        public static char LocAb { get; set; }
        public static string LocName { get; set; }
    }
}
