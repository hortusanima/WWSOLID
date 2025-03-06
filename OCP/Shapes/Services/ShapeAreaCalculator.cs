using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Services
{
    public class ShapeAreaCalculator
    {
        private readonly I2DShape _shape;

        public ShapeAreaCalculator(I2DShape shape)
        {
            _shape = shape;
        }

        public string DisplayArea()
        {
            return $"Area of {_shape.GetType().Name.ToString().ToLower()}: {_shape.CalculateArea()}";
        }
    }
}
