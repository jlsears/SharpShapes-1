using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square2 : Quadrilateral
    {

        public Square2()
        {
        }

        public Square2(float Top, float Right) { }

        public override float Area()
        {
            return this.Top * 2;
        }
    }
}
