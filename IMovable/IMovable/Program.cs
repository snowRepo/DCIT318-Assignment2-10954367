using System;
using IMovables;

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car_Class();
        IMovable bicycle = new Bicycle_Class();


        car.Move();
        bicycle.Move();
    }
}