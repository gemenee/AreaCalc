using AreaCalculator.Shapes;

namespace AreaCalculatorTests;

[TestClass]
public class AreaCalculatorTests
{
	[TestMethod]
	public void ValidateTriangleMeasures_InvalidMeasures_ThrowsException()
	{
		Assert.ThrowsException<ArgumentException>(() => new Triangle(4, 2, 2));
	}

	[TestMethod]
	public void ValidateTriangleMeasures_NegativeMeasures_ThrowsException()
	{
		Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, 2, 2));
	}

	[TestMethod]
	public void ValidateCircleMeasures_NegativeRadius_ThrowsException()
	{
		Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
	}

	[TestMethod]
	public void CalculateTriangleArea_CorrectMeasures_CorrectArea()
	{
		var t = new Triangle(2, 2, 2);

		Assert.AreEqual(1.7320508075688772, t.Area);
	}

	[TestMethod]
	public void CalculateCircleArea_CorrectRadius_CorrectArea()
	{
		Assert.AreEqual(314.1592653589793, new Circle(10).Area);
	}

	[TestMethod]
	public void FindIfTriangleIsRight_CorrectMeasures_True()
	{
		Assert.AreEqual(true, new Triangle(5, 4, 3).IsRightTriangle);
	}

	[TestMethod]
	public void FindIfTriangleIsRight_IncorrectMeasures_False()
	{
		Assert.AreEqual(false, new Triangle(5, 4, 2).IsRightTriangle);
	}
}