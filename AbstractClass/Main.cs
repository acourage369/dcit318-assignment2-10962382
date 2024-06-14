using Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Shape
    {
        static void Main(string[] args)
        {
            //Instances of Circle
            Circle circle = new Circle(5.0);
            //Instance of Rectangle
            Rectangle rectangle = new Rectangle(2.0, 3.0);


            //Area of circle
            Console.WriteLine($"The area of the circle is: {circle.GetArea()}");
            Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");
        }
    }
}
