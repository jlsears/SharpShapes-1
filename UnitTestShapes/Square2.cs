using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShapes
{
    public class Square2 : Quadrilateral
    {
        //public float height { get; set; }
        // public float width { get; set; }

        public Square2()
        {
        }

        public Square2(float Top, float Right) { }

        public override float Area()
        {
            return this.Top * this.Right;
        }
    }
}
