using OCP.Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Shapes.Services
{
    public class ShapeVolumeCalculator
    {
        private readonly I3DShape _shape;
        public ShapeVolumeCalculator(I3DShape shape)
        {
            _shape = shape;
        }

        public string DisplayVolume()
        {
            return $"Volume of {_shape.GetType().Name.ToString().ToLower()}: {_shape.CalculateVolume()}";
        }
    }
}
