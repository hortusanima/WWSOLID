using OCP.Shape;

namespace OCP.Shapes
{
    class Square : IShape
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            return this.Side * this.Side;
        }
    }
}
