using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{
    internal class Implicit_typecasting
    {
        public static void Main()
        {
            int number = 123;
            double result = number; // Implicit casting from int to double

            Console.WriteLine(result); // Outputs: 123.0

            Console.ReadLine();
        }
    }
}
