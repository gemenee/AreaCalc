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
        public void CalculateArea()
        {
            Triangle triangle = new Triangle(2, 2, 2);

            Assert.AreEqual(1.73, triangle.Area);
        }
    }
}