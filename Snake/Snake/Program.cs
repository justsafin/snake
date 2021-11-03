using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 5, '*');
            Point p2 = new Point(5, 2, '#');
            Point p3 = new Point(6, 7, '&');
            Point p4 = new Point(9, 3, '?');

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);
            
            foreach (Point i in pointList)
            {
                i.Draw();
            }


            Console.ReadLine();
        }


    }
}
