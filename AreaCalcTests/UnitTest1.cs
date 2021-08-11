using NUnit.Framework;
using AreaCalc;
using System.Configuration;


namespace AreaCalcTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThrowsExceptionIfInvalidTriangle()
        {
            Calculator calc = new Calculator();
            Assert.Throws<System.ArgumentException>(()=> calc.CalculateTriangleArea(4, 2, 2));
        }

        [Test]
        public void ThrowsExceptionIfNegativeMeasures()
        {
            Calculator calc = new Calculator();
            Assert.Throws<System.ArgumentException>(()=> calc.CalculateTriangleArea(-2, 2, 2));

        }


        [Test]
        public void CalculateTriangleArea()
        {
            Calculator  calc = new Calculator();

            Assert.AreEqual(1.73, calc.CalculateTriangleArea(2,2,2));
        }
        [Test]
        public void CalculateCircleArea()
        {
            Calculator  calc = new Calculator();

            Assert.AreEqual(314.16, calc.CalculateCircleArea(10));
        }


    }
}