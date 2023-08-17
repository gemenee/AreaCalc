using AreaCalculator.Shapes;

namespace Application;

internal class Program
{
	static void Main(string[] args)
	{
		var shapes = new List<IShape> 
		{
			new Triangle(2, 2, 2),
			new Triangle(5, 4, 3),
			new Circle(10)
		};

		foreach (var shape in shapes)
		{
			Console.WriteLine(shape.Area);
			Console.ReadLine();
		}
	}
}