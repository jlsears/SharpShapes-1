using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public float height { get; set; }
        public float width { get; set; }

    public override float Area() 
        {
            return this.height * this.width;
        }
    }
}
