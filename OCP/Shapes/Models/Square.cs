using OCP.Shapes.Interfaces;

namespace OCP.Shapes.Models
{
    class Square : IShape
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
