using OCP.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Shapes
{
    public class Trapezoid : IShape
    {
        public double FirstBase { get; set; }
        public double SecondBase { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 1.5 * (this.FirstBase + this.SecondBase) * this.Height;
        }
    }
}
