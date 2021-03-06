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
        public void ThrowsIfNegativeTriangleMeasures()
        {
            Calculator calc = new Calculator();
            Assert.Throws<System.ArgumentException>(()=> calc.CalculateTriangleArea(-2, 2, 2));

        }
        [Test]
        public void ThrowsIfNegativeCircleMeasures()
        {
            Calculator calc = new Calculator();
            Assert.Throws<System.ArgumentException>(()=> calc.CalculateCircleArea(-1));
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

        [Test]
        public void TrueIfRightTriangle()
        {
            Calculator  calc = new Calculator();

            Assert.AreEqual(true, new Triangle(5, 4, 3).IsRightTriangle);
        }

        [Test]
        public void FalseIfNotRightTriangle()
        {
            Calculator  calc = new Calculator();

            Assert.AreEqual(false, new Triangle(5, 4, 2).IsRightTriangle);
        }




    }
}