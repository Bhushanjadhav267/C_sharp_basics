using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{

    public class Person
    {
        // Fields
        public string Name;
        public int Age;

        // Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default constructor called. Name set to 'Unknown' and Age set to 0.");
        }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Parameterized constructor called. Name set to '{name}' and Age set to {age}.");
        }

        // Method to display person details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    internal class Constructor
    {

        public static void Main(string[] args)
        {
            // Creating an object using the default constructor
            Person person1 = new Person();
            person1.DisplayInfo(); // Output: Name: Unknown, Age: 0

            // Creating an object using the parameterized constructor
            Person person2 = new Person("Alice", 30);
            person2.DisplayInfo(); // Output: Name: Alice, Age: 30

            Console.ReadLine();
        }
    }
}
