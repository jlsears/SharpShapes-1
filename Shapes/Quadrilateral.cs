using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media; // How we get our brushes
//using System.Drawing;
using System.Windows;

namespace Shapes
{
    public class Quadrilateral : Shape
    {
        private float bottom;
        private float top;
        private float left;
        private float right;

        public float Top
        {

            get { return top; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    top = value;
                }
            }
        }


        public float Bottom
        {

            get { return bottom; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    bottom = value;
                }
            }
        }

        public float Left
        {
            get { return left; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    left = value;
                }
            }
        }


        public float Right
        {
            get { return right; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    right = value;
                }
            }
        }

        // Calls Shape's Constructor that provides default fill and border colors.
        public Quadrilateral() : base() { }

        // Still need to call parent constructor/base class here
        public Quadrilateral(float top, float bottom, float left, float right) : base()
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        public override float Perimeter()
        {
            if (Top == 0.0 || Bottom == 0.0 || Left == 0.0 || Right == 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return Top + Bottom + Left + Right;
            }

        }

        public override void Scale(int percent)
        {
            // Limiting the bounds of the shape
            if (percent == 0 || percent <= -100)
            {
                throw new ArgumentException();
            }

            // This mathyness: part in parens equivalent to 1.05 for 5%, 1.20 for 20%, etc.
            this.Top = Top * (100 + percent) / 100;
            this.Bottom = Bottom * (100 + percent) / 100;
            this.Left = Left * (100 + percent) / 100;
            this.Right = Right * (100 + percent) / 100;
        }

        public Polygon CreatePolygon()
        {
            Polygon poly = new Polygon();
            // SolidBrush b = 
            poly.Fill = new SolidColorBrush(this.FillColor);
            poly.Stroke = new SolidColorBrush(this.BorderColor);
            poly.StrokeThickness = 2;
            return poly;
        }

        public override void DrawOnto(Canvas theCanvas, int x, int y)
        {
            Polygon myPolygon = CreatePolygon();
            Point p1 = new Point(x, y);
            Point p2 = new Point(x, y + this.Left); // Or this.Right
            Point p3 = new Point(x + this.Bottom, y + Right);
            Point p4 = new Point(x + this.Top, y);
            PointCollection myPoints = new PointCollection();
            myPoints.Add(p1); // Need to have points to add to collection
            myPoints.Add(p2);
            myPoints.Add(p3);
            myPoints.Add(p4); // Adding them to collection below
            myPolygon.Points = myPoints;

            // Calling this method draws the polygon on the canvas
            theCanvas.Children.Add(myPolygon);
        }
    }
}