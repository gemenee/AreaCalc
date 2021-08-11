using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;

namespace AreaCalc
{
    public class Calculator
    {
        readonly int decimalPlaces;
        public IConfiguration AppConfiguration { get; set; }
        public Calculator()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            AppConfiguration = builder.Build();
            decimalPlaces = Int32.Parse(AppConfiguration["decimal_places"], System.Globalization.NumberStyles.Integer);
        }




        public double CalculateCircleArea(double radius)
        {
            return Math.Round(new Circle(radius).Area, decimalPlaces);
        }

        public double CalculateTriangleArea(double side1, double side2, double side3)
        {
            return Math.Round(new Triangle(side1, side2, side3).Area, decimalPlaces);
        }
    }
}
