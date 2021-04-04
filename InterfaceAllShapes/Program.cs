using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAllShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure rectangle = new Rectangle(5, 10);
            rectangle.ComputeArea();
            Console.WriteLine(rectangle.ToString());

            GeometricFigure square = new Square(5, 10);
            square.ComputeArea();
            Console.WriteLine(square.ToString());

            GeometricFigure square02 = new Square(10);
            square02.ComputeArea();
            Console.WriteLine(square02.ToString());

            GeometricFigure triangle = new Triangle(5, 10);
            triangle.ComputeArea();
            Console.WriteLine(triangle.ToString());

            Console.ReadKey();
        }
    }
}
