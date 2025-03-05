using OCP.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Shapes
{
    public class Hexagon : IShape
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            return (3 * Math.Sqrt(3) * this.Side * this.Side)/2;
        }
    }
}
