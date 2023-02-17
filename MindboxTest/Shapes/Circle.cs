namespace MindboxTest.Shapes;

/// <summary>
/// Круг
/// </summary>
public class Circle : Shape
{
	/// <summary>
	/// Радиус
	/// </summary>
	public double R { get; }

	public Circle(double r)
	{
		R = r;
	}

	public override double Area => Math.PI * R * R;

	public override string ToString()
	{
		return $@"R = {R}
Area = {Area}";
	}
}