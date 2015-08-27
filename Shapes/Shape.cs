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
        //Below C# is creating the data members for us. Yaaay!
        //Color fillColor;
        //Color borderColor;

        /// <summary>
        /// "protected set" allows for child classes to use the setter!
        /// </summary>
        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }

        // Comes from the ConcreteSHape class in ShapeTest
        public Shape()
        {
            BorderColor = Color.NavajoWhite;
            FillColor = Color.PapayaWhip;
        }

        public virtual float Area() { throw new NotImplementedException(); }
        public virtual float Perimeter() { throw new NotImplementedException(); }
    }
}
