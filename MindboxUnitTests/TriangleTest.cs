using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest.Shapes;

namespace MindboxUnitTests;

[TestClass]
public class TriangleTest
{
	[TestMethod]
	[DataRow(10, 10, 10, 43.30127018922193)]
	[DataRow(20, 20, 20, 173.20508075688772)]
	public void TestArea(double a, double b, double c, double area)
	{
		var triangle = new Triangle(a, b, c);
		Assert.AreEqual(area, triangle.Area);
	}

	[TestMethod]
	public void TestIs()
	{
		var triangle = new Triangle(0, 0, 0);
		Assert.IsTrue(triangle.Is<Triangle>());
	}

	[TestMethod]
	public void TestNotIs()
	{
		var triangle = new Triangle(0, 0, 0);
		Assert.IsFalse(triangle.Is<Circle>());
	}
}