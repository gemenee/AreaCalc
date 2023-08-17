namespace AreaCalculator.Shapes;

public class Circle : IShape
{
	public double Radius { get; }
	public double Area => Math.Pow(Radius, 2) * Math.PI;

	public Circle(double radius)
	{
		if (radius > 0) Radius = radius;
		else throw new ArgumentException("Positive radius expected");
	}
}
