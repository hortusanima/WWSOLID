using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Services
{
    public class ShapeAreaCalculator
    {
        private readonly IShape _shape;

        public ShapeAreaCalculator(IShape shape)
        {
            _shape = shape;
        }

        public string DisplayArea()
        {
            return $"Area of {_shape.GetType().Name.ToString().ToLower()}: {_shape.CalculateArea()}";
        }
    }
}
