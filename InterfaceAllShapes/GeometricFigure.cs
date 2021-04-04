using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAllShapes
{
    abstract class GeometricFigure
    {
        private double height;
        private double width;
        protected double area;

        public double Height
        {
            get
            {
                return height;
            }
            set 
            {
                height = value;
            }
        }
        public double Width {
            get 
            {
                return width;
            }
            set 
            {
                width = value;
            }
        }

        public double Area { get { return area; } }

        public abstract void ComputeArea();

        public override string ToString()
        {
            return $"Type: {GetType()} -- Height: {Height} -- Width: {Width} -- Area: {Area}";
        }
    }
}
