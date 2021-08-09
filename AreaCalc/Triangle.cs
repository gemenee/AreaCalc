using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration ;

namespace AreaCalc
{
    public class Triangle : IShape
    {
        double Side1 { get; }
        double Side2 { get; }
        double Side3 { get; }

        double HalfPerimeter => (Side1 + Side2 + Side3) * 0.5;
        public bool IsRightTriangle { get; }
        public double Area => Math.Round(Math.Sqrt(HalfPerimeter*(HalfPerimeter - Side1) * (HalfPerimeter - Side2) * (HalfPerimeter - Side3)), 2);

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 > 0 && side2 > 0 && side3 > 0 &&
                side1 + side2 > side3 && 
                side2 + side3 > side1 && 
                side1 + side3 > side2)
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
                IsRightTriangle = side1 * side1 == side2 * side2 + side3 * side3 || 
                                  side2 * side2 == side1 * side1 + side3 * side3 ||
                                  side3 * side3 == side2 * side2 + side1 * side1;
            }
            else throw new ArgumentException("Check side length");

        }
    }
}
