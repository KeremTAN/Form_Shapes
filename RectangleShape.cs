using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShapes
{
    class RectangleShape : Shape, IShape
    {
        double edge1=0, edge2=0;
        public RectangleShape(int edge1, int edge2)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
        }
        public double CalculateArea() => edge1*edge2;
        public double CalculatePerimeter() => edge1 * 2 + edge2 * 2;
    }
}
