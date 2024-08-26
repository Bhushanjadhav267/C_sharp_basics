using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    internal class Method_Overloading
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));       // Calls Add(int, int)
            Console.WriteLine(calc.Add(2, 3, 4));    // Calls Add(int, int, int)
            Console.WriteLine(calc.Add(2.5, 3.5));   // Calls Add(double, double)

            Console.ReadLine();
        }
    }
}
