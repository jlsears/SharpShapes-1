using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle2 : Quadrilateral
    {

        public Rectangle2(float height, float width) : base()
        {
            Top = width;
            Bottom = width;
            Left = height;
            Right = height;
        }

        /// <summary>
        ///  Calculate Area for a Shape
        /// </summary>
        /// <returns>Area as a float</returns>


        public override float Area()
        {
            if (Top == 0.0 || Right == 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.Top * this.Right;
            }
        }
    }
}
