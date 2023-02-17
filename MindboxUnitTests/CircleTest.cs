using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest.Shapes;

namespace MindboxUnitTests;

[TestClass]
public class CircleTest
{
	[TestMethod]
	[DataRow(10, 314.1592653589793)]
	[DataRow(20, 1256.6370614359173)]
	public void TestArea(double r, double area)
	{
		var circle = new Circle(r);
		Assert.AreEqual(area, circle.Area);
	}

	[TestMethod]
	public void TestIs()
	{
		var circle = new Circle(0);
		Assert.IsTrue(circle.Is<Circle>());
	}

	[TestMethod]
	public void TestNotIs()
	{
		var circle = new Circle(0);
		Assert.IsFalse(circle.Is<Triangle>());
	}
}