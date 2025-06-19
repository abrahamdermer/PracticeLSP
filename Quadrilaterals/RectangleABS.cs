using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPתרגול.Quadrilaterals
{
    abstract class RectangleABS
    {
        public abstract double Width { get; protected  set; }
        public abstract double Height { get; protected set; }
        public double Area()
        {
            return Width * Height;
        }

        public abstract void SetWidth(double w);
        public abstract void SetHeight(double h);
    }
}

