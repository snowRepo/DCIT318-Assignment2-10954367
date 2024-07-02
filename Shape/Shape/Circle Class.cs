using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle_Class : Shape_Class
    {
        private double radius;

        public Circle_Class(double radius) { this.radius = radius; }

        public override double GetArea() { 

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
