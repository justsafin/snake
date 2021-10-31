using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.Draw(2, 5, '*');
            p2.Draw(5, 2, '#');


            Console.ReadLine();
        }

    }
}
