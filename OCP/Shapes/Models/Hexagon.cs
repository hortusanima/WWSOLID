using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    public class Hexagon : I2DShape
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            return 3 * Math.Sqrt(3) * Side * Side/2;
        }
    }
}
