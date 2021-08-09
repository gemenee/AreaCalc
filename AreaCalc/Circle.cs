using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    class Circle : IShape
    {
        public double Radius { get; }
        public double Area => Math.Pow(Radius, 2) * Math.PI;

        public Circle(double radius)
        {
            if (radius > 0) Radius = radius;
        }
    }
}
