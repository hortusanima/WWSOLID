using OCP.Shape;

namespace OCP.Shapes
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return this.Length * this.Width;
        }
    }
}
