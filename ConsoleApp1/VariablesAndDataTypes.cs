using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VariablesAndDataTypes
    {
        static void Main(string[] args)
        {
            int number = 10; // Integer variable
            double pi = 3.14; // Double variable
            char initial = 'A'; // Character variable  
            string greeting = "Hello, World!"; // String variable
            bool isActive = true; // Boolean variable

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Initial: {initial}");
            Console.WriteLine($"Greeting: {greeting}");
            Console.WriteLine($"Is Active: {isActive}");

            Console.ReadLine();
        }
        }
}
