using Shape;
using System;

class Program
{
    static void Main(string[] args)
    {
        Shape_Class Circle = new Circle_Class(7.0);
        Shape_Class Rectangle = new Rectangle_Class(6.0, 9.0);


        Console.WriteLine("Area of circle is: " + Circle.GetArea());
        Console.WriteLine("Area of rectangleis: " + Rectangle.GetArea());
    }
}