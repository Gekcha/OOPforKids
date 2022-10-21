using System;
using System.Collections.Generic;
using System.Text;

namespace MemeHierarchy.Geometry
{
    class Rectangle
    {
        Point p1;
        Point p2;

        public Rectangle(Point _p1, Point _p2)
        {
            p1 = _p1;
            p2 = _p2;
        }

        public void Draw()
        {

            p1.Draw();
            p2.Draw();
        }
    }
}
