using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    public class Trapezoid : IShape
    {
        public double FirstBase { get; set; }
        public double SecondBase { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 1.5 * (FirstBase + SecondBase) * Height;
        }
    }
}
