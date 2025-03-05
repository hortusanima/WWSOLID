using OCP.Shape;

namespace OCP.Shapes
{
    class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 0.5 * this.Base * this.Height;
        }
    }
}
