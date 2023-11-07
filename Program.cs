using System;

namespace GrundernaOOPLabFive;

class Program
{
    static void Main(string[] args)
    {
        //Creating new objects of Circle class
        Circle circleOne = new Circle(5);
        Circle circleTwo = new Circle(6);

        double areaOne = circleOne.GetArea();
        Console.WriteLine("Circle area with radious 5: "+ areaOne);

        double areaTwo = circleTwo.GetArea();
        Console.WriteLine("Circle area with radious 6: " + areaTwo);

        Console.ReadLine();
    }
}

