using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Basics
{

    public class Perso

    {
        private int id;
        // public void set(int value) 
        //    {
        //           this.id = value;
        //    }
        //public int getId()
        //{
        //    return this.id;
        //}

        public int Id
        { 
            set { id = value; }
            get { return id; }
        }
    }
    internal class Encapsulation
    {
        public static void Main(string[] args)
        {
            Perso e = new Perso();
            //e.set(3);
            //Console.WriteLine(e.getId());
            e.Id = 5;
            Console.WriteLine(e.Id);
         Console.ReadLine();
        }
    }
}


//second method for same 
/*
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "John Doe"; // Set the property
        person.Age = 25; // Set the property

        Console.WriteLine($"Name: {person.Name}"); // Get the property
        Console.WriteLine($"Age: {person.Age}"); // Get the property
    }
}
*/