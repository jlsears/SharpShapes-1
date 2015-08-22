using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Shapes
{
    public abstract class Shape : IShape
    {
        // We need info about colors
        Color fillColor;
        Color borderColor;

        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }

        public abstract float Area();


        public abstract float Perimeter();
    }
}
