using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAllShapes
{
    class Square : Rectangle
    {
        public Square(double height, double width) : base(height, width)
        {
            if(height != width)
            {
                Width = height;
                Height = height;
            }
            else
            Width = width;
            Height = height;
        }
        public Square(double height) : base(height, height)
        {
            Width = height;
            Height = height;
        }

        public override void ComputeArea()
        {
            base.ComputeArea();
        }
    }
}
