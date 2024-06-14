using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Interface
    {
        static void Main(string[] args)
        {
            //Instance of Car
            Car car = new Car();
            //Instance of Bicycle
            Bicycle bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
