using OCP.Shapes;

var circle = new Circle { Radius = 5 };
var rectangle = new Rectangle { Length = 4, Width = 6 };
var square = new Square { Side = 4 };
var triangle = new Triangle { Base = 4, Height = 6 };

Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
Console.WriteLine($"Area of rectangle: {rectangle.CalculateArea()}");
Console.WriteLine($"Area of square: {square.CalculateArea()}");
Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");