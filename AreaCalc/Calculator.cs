using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    class Calculator
    {
        public double CalculateCircleArea(double radius)
        {
            return new Circle(radius).Area;
        }

        public double CalculateTriangleArea(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).Area;
        }
    }
}
