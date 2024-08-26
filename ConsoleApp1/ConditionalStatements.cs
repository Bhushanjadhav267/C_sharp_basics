using System;

namespace C_sharp_Basics
{
    class ConditionalStatements
{
        static void Main(string[] args)
        {
            int number = 15;

            // if-else if-else example ..
            if (number < 10)
            {
                Console.WriteLine("Number is less than 10.");
            }
            else if (number == 10)
            {
                Console.WriteLine("Number is 10.");
            }
            else
            {
                Console.WriteLine("Number is greater than 10.");
            }

            // switch example
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good!");
                    break;
                case 'C':
                    Console.WriteLine("Fair!");
                    break;
                case 'D':
                    Console.WriteLine("Needs Improvement!");
                    break;
                case 'F':
                    Console.WriteLine("Fail!");
                    break;
                default:
                    Console.WriteLine("Invalid Grade.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
