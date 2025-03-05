using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
