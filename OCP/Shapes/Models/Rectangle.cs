using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    public class Rectangle : I2DShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
