using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{
    internal class MethodsExample
    {
        static void Main(string[] args)
        {
            int result = Add(5, 10); // Method call   with arguments
            Console.WriteLine($"Sum: {result}");

            string greeting = GetGreeting("John");
            Console.WriteLine(greeting);

            Console.ReadLine();
        }

        // Method with parameters and return type
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Method with a string return type
        static string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
}

