using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 5, '*');
            Point p2 = new Point(5, 2, '#');

            p1.Draw();
            p2.Draw();


            Console.ReadLine();
        }

    }
}
