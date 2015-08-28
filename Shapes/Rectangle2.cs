using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle2 : Quadrilateral
    {

        public Rectangle2()
        {
        }

        public Rectangle2(float Top, float Right) { }

        public override float Area()
        {
            return this.Top * this.Right;
        }
    }
}
