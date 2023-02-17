namespace MindboxTest.Shapes;

/// <summary>
/// Фигура
/// </summary>
public abstract class Shape : IShapeArea
{
	public abstract double Area { get; }

	public bool Is<T>() where T : Shape
	{
		return this is T;
	}
}