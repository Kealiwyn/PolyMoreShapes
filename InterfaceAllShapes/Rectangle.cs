using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAllShapes
{
    class Rectangle : GeometricFigure
    {

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override void ComputeArea()
        {
            area = Width * Height;
        }
    }
}
