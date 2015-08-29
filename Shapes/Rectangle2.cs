using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle2 : Quadrilateral
    {

        public Rectangle2() : base()
        {
        }

        public Rectangle2(float Top, float Right) : base() { }

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
