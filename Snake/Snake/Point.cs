using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public int scr;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(int _x, int _y, int _scr)
        {
            x = _x;
            y = _y;
            scr = _scr;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Directions direction)
        {
            if(direction == Directions.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Directions.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Directions.UP)
            {
                y = y - offset;
            }
            else if (direction == Directions.DOWN)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void DrawScr()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(scr);
        }
        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
