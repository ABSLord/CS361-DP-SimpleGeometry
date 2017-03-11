using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }

        public override double Area()
        {
            double area = 0;
            var circle = (Circle)this;
            area = circle.Radius * circle.Radius * Math.PI;
            return area;
        }

        public override string Print()
        {
            return ($"Circle: radius = {this.Radius}, area = {this.Area()}");
        }
    }
}
