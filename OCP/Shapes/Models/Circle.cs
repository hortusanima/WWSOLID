using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
