using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;

namespace SimpleGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> printables = new List<IPrintable>();

            //List<Shape> shapes = new List<Shape>();
            printables.Add(new Circle(1));
            printables.Add(new Triangle(6, 5, 4));
            printables.Add(new RightAngledTriangle(3, 4));

            foreach (var printable in printables)
               ShapePrinter.Print(printable);

            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
