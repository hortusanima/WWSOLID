
using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    public class Cube : I2DShape, I3DShape
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            return 6 * this.Side * this.Side;
        }

        public double CalculateVolume()
        {
            return this.Side * this.Side * this.Side;
        }
    }
}
