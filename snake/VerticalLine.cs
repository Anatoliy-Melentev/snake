using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class VerticalLine : figure
    {
        public VerticalLine(int xUp, int xDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = xUp; y <= xDown; y++) {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
