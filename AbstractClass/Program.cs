// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;
namespace Abstract
{
    //Abstract class
    abstract class Shape()
    {
        //Abstract method to be implemented by a derived class
        public abstract double GetArea();
    }

    //Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        //Abstract method GetArea implementing
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        //Derived class Rectangle
        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            //Abstract method GetArea implementation
            public override double GetArea()
            {
                return Width * Height;
            }
        }
    }
}