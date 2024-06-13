using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    internal class OOP
    {
        static void Main(string[] args)
        {
            //Instance of Animal
            Animal animal = new Animal();
            //Instance of Dog
            Dog dog = new Dog();
            //Instance oof Cat
            Cat cat = new Cat();

            //Calling MakeSound method on each method
            animal.MakeSound();   //Output Moooooo
            dog.MakeSound();      //Output Bark
            cat.MakeSound();      //Output Meow
        }
    }
}
