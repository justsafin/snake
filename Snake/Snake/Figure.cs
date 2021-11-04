using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        public List<Point> pList;
        public void lineDraw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
