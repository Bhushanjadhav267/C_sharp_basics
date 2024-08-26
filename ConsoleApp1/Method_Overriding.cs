using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{
    public class Animal
    {
        // Virtual method that can be overridden  
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    public class Dog : Animal
    {
        // Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        // Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    internal class Method_Overriding
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog();  // Base class reference to derived class
            myAnimal.MakeSound();        // Outputs: Bark

            myAnimal = new Cat();        // Changing the reference to another derived class
            myAnimal.MakeSound();       // Outputs: Meow

            Console.ReadLine();
        }
    }
}
