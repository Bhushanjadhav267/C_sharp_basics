using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{
    internal class Explicit_typecasting
    {
        public static void Main()
        {
            double pi = 3.14;
            int roundedPi = (int)pi; // .Explicit casting from double to int

            Console.WriteLine(roundedPi); // Outputs: 3
        }
    }
}
