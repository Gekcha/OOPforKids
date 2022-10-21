using System;
using System.Collections.Generic;
using System.Text;

namespace MemeHierarchy.Geometry
{
    class Point
    {
        int x, y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Draw()
        {
            Console.WriteLine($"Point coordinates: ({x},{y})");
        }
    }
}
