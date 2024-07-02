using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovables
{
    internal class Car_Class : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
