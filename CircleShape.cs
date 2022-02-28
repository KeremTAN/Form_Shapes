using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShapes
{
     class CircleShape : Shape, IShape
    {
        double radiusX, radiusY;
        public CircleShape(int radiusX, int radiusY)
        {
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }
        public double CalculateArea() => Math.PI * radiusX * radiusY;
        public double CalculatePerimeter() => 2*Math.PI*Math.Sqrt((0.5)*(Math.Pow(radiusX,2)+ Math.Pow(radiusY, 2)));
    }
}
