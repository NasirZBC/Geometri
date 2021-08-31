using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squareOne = new Square();
            squareOne.SquareLength = 5;

            float test = squareOne.SquareAreaCalc();

            Console.WriteLine(test);

        }
    }
}
