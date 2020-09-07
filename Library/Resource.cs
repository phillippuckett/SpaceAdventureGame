using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{

    public class Resource
    {
        public static int Gold { get; set; }
        public static int Fuel { get; set; }
        public static int Food { get; set; }
        public static int Water { get; set; }
        public static int Rock { get; set; }

        public static void Attrition() 
        {
            Fuel -= 1;
            Food -= 1;
            Water -= 1;
        }
    }
}
