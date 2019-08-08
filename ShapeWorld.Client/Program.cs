using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
          PlayWithShape();
        }

        private static void PlayWithShape()
        {
          Square someSquare = new Square();
          Rectangle someRectangle = new Rectangle();
          System.Console.WriteLine("Square perimeter = "+ someSquare.Perimeter());
          System.Console.WriteLine("Rectangle perimeter = "+ someRectangle.Perimeter());
          System.Console.WriteLine("Square area = "+ someSquare.Area());
          System.Console.WriteLine("Rectangle perimeter = "+ someRectangle.Area());
        }
    }

}
