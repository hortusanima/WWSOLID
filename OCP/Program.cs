using OCP.Shapes.Models;
using OCP.Shapes.Services;

var circle = new Circle { Radius = 5 };
var rectangle = new Rectangle { Length = 4, Width = 6 };
var square = new Square { Side = 4 };
var triangle = new Triangle { Base = 4, Height = 6 };
var hexagon = new Hexagon { Side = 2 };
var trapezoid = new Trapezoid { FirstBase = 6, SecondBase = 3, Height = 3 };

var circleCalculator = new ShapeAreaCalculator(circle);
var rectangleCalculator = new ShapeAreaCalculator(rectangle);
var squareCalculator = new ShapeAreaCalculator(square);
var triangleCalculator = new ShapeAreaCalculator(triangle);
var hexagonCalculator = new ShapeAreaCalculator(hexagon);
var trapezoidCalculator = new ShapeAreaCalculator(trapezoid);

Console.WriteLine(circleCalculator.DisplayArea());
Console.WriteLine(rectangleCalculator.DisplayArea());
Console.WriteLine(squareCalculator.DisplayArea());
Console.WriteLine(triangleCalculator.DisplayArea());
Console.WriteLine(hexagonCalculator.DisplayArea());
Console.WriteLine(trapezoidCalculator.DisplayArea());