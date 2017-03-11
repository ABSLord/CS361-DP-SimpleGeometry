using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GeometryLib.Shapes
{
    public class Square: Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Debug.Assert(side > 0, "side > 0");
            Side = side;
        }

        public override double Area()
        {
            double area = 0;
            var side = this.Side;
            area = side * side;
            return area;
        }

        public override string Print()
        {
            return ($"Square: side: {this.Side}, area = {this.Area()}");
        }
    }
}
