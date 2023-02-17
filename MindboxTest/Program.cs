// See https://aka.ms/new-console-template for more information

using MindboxTest.Shapes;

var shapes = new List<Shape>
{
	new Circle(10),
	new Triangle(10, 10, 10),
};

Console.WriteLine(string.Join(Environment.NewLine,
	shapes.Select(shape => shape.Area)));

Console.WriteLine("Circle is circle - "+shapes[0].Is<Circle>());
Console.WriteLine("Triangle is circle - "+shapes[1].Is<Circle>());
Console.WriteLine("Circle is triangle - "+shapes[0].Is<Triangle>());
Console.WriteLine("Triangle is triangle - "+shapes[1].Is<Triangle>());