using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPתרגול.Quadrilaterals
{
    internal class Rectangle:RectangleABS
    {
        public override double Width { get; protected set; }
        public override double Height { get; protected set; }
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public override void SetWidth(double w)
        {
            if(w<0)
                Width = w;
        }
        public override void  SetHeight (double num)
        {
            if(num<0)
                Width = num;
        }
    }
}
