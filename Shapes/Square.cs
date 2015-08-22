using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Quadrilateral
    {
        public float side { get; set; }

        public override float Area()
        {
            return this.side * 4;
        }
    }
}
