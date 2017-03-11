using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Прямоугольный треугольник
    /// </summary>
    public class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle(double side1, double side2)
            : base(side1, side2, Math.Sqrt(side1 * side1 + side2 * side2))
        {
        }
        public override double Area()
        {
            double area = 0;
            var rightTriangle = (RightAngledTriangle)this;
            area = 0.5 * rightTriangle.Side1 * rightTriangle.Side2;
            return area;
        }

        public override string Print()
        {
            var info = "Right-angled Triangle: ";
            info += $"sides {this.Side1} {this.Side2} {this.Side3}, ";
            info += $"area = {this.Area()}";
            return (info);
        }
    }
}
