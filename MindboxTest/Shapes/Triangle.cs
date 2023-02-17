namespace MindboxTest.Shapes;

/// <summary>
/// Триугольник
/// </summary>
public class Triangle : Shape
{
	/// <summary>
	/// Первая сторона
	/// </summary>
	public double A { get; }

	/// <summary>
	/// Вторая сторона
	/// </summary>
	public double B { get; }

	/// <summary>
	/// Третья сторона
	/// </summary>
	public double C { get; }

	public Triangle(double a, double b, double c)
	{
		A = a;
		B = b;
		C = c;
	}

	public override double Area
	{
		get
		{
			var p = (A + B + C) / 2;
			return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		}
	}

	public override string ToString()
	{
		return $@"A = {A}
B = {B}
C = {C}
Area = {Area}";
	}
}