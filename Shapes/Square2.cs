using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square2 : Quadrilateral
    {

        public Square2() : base()
        {
        }

        public Square2(float Top) : base() { }

        public override float Area()
        {
            if (Top == 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.Top * 2;
            }
        }
    }
}
