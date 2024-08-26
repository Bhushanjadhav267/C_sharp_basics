using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics

{
    internal class LoopsExample
    {
        static void Main(string[] args)
        {
            // for loop example 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For Loop Iteration: {i}");
            }

            // while loop example
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"While Loop Counter: {counter}");
                counter++;
            }

            // do-while loop example
            int doCounter = 0;
            do
            {
                Console.WriteLine($"Do-While Loop Counter: {doCounter}");
                doCounter++;
            } while (doCounter < 2);

            Console.ReadLine();
        }
    }
}
