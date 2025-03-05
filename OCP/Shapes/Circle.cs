using OCP.Shape;

namespace OCP.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
