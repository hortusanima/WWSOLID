using OCP.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Shapes
{
    public class ShapeAreaCalculator
    {
        private readonly IShape _shape;

        public ShapeAreaCalculator(IShape shape)
        {
            _shape = shape;
        }

        public string DisplayArea()
        {
            return $"Area of {_shape.GetType().Name.ToString().ToLower()}: {_shape.CalculateArea()}";
        }
    }
}
