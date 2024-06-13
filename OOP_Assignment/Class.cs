// See https://aka.ms/new-console-template for more information
using System;
namespace OOP
{
    //The base class
    class Animal
    {
        //Virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine("Mooooo");
        }
    }

    //The derived class
    class Dog : Animal
    {
        //Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    //Derived class
    class Cat : Animal
    {
        //Method overriding
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}