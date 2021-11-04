using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int ytop, int ybot, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = ytop; y <= ybot; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void lineDraw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
