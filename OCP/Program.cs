using OCP.Shapes.Models;
using OCP.Shapes.Services;

var circle = new Circle { Radius = 5 };
var rectangle = new Rectangle { Length = 4, Width = 6 };
var square = new Square { Side = 4 };
var triangle = new Triangle { Base = 4, Height = 6 };
var hexagon = new Hexagon { Side = 2 };
var trapezoid = new Trapezoid { FirstBase = 6, SecondBase = 3, Height = 3 };
var cube = new Cube { Side = 5 };

var circleAreaCalculator = new ShapeAreaCalculator(circle);
var rectangleAreaCalculator = new ShapeAreaCalculator(rectangle);
var squareAreaCalculator = new ShapeAreaCalculator(square);
var triangleAreaCalculator = new ShapeAreaCalculator(triangle);
var hexagonAreaCalculator = new ShapeAreaCalculator(hexagon);
var trapezoidAreaCalculator = new ShapeAreaCalculator(trapezoid);
var cubeAreaCalculator = new ShapeAreaCalculator(cube);

var cubeVolumeCalculator = new ShapeVolumeCalculator(cube);

Console.WriteLine(circleAreaCalculator.DisplayArea());
Console.WriteLine(rectangleAreaCalculator.DisplayArea());
Console.WriteLine(squareAreaCalculator.DisplayArea());
Console.WriteLine(triangleAreaCalculator.DisplayArea());
Console.WriteLine(hexagonAreaCalculator.DisplayArea());
Console.WriteLine(trapezoidAreaCalculator.DisplayArea());
Console.WriteLine(cubeAreaCalculator.DisplayArea());

Console.WriteLine(cubeVolumeCalculator.DisplayVolume());