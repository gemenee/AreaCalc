using AreaCalculator.Shapes;

namespace AreaCalculator;

public class Calculator
{
	public static double CalculateCircleArea(double radius, int decimalPlaces = 2)
	{
		return Math.Round(new Circle(radius).Area, decimalPlaces);
	}

	public static double CalculateTriangleArea(double side1, double side2, double side3, int decimalPlaces = 2)
	{
		return Math.Round(new Triangle(side1, side2, side3).Area, decimalPlaces);
	}
}