using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape //Made public, abstract, & implemented classes (Quick Actions)
    {
        
        public float Side1 { get; set; }
        public float Side2 { get; set; }
        public float Side3 { get; set; }
        public float Side4 { get; set; }

        public abstract override float Area();

        public override float Perimeter()
        {
            return this.Side1 + this.Side2 + this.Side3 + this.Side4;
        }
    }
}
