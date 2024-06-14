// See https://aka.ms/new-console-template for more information
using System;

namespace Interfaces
{
    //IMovable Interface
    public interface IMovable
    {
        //A void method Move
        void Move();

    }

    //Car class implementing IMovable Interface
    public class Car : IMovable
    {
        public void Move() 
        {
            Console.WriteLine("Car is moving");
        }
    }

    //Bicycle class implementing IMovable Interface
    public class Bicycle : IMovable
    {
        public void Move() 
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}