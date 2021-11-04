using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int mapWidth = 78;
            int mapHeight = 25;

            Point p1 = new Point(2, 5, '*');

            HorizontalLine topHline = new HorizontalLine(0, mapWidth, 0, '-');
            HorizontalLine botHline = new HorizontalLine(0, mapWidth, mapHeight, '-');
            VerticalLine leftVline = new VerticalLine(0, mapHeight, 0, '|');
            VerticalLine rightVline = new VerticalLine(0, mapHeight, mapWidth, '|');
            
            leftVline.lineDraw();
            rightVline.lineDraw();
            topHline.lineDraw();
            botHline.lineDraw();

            Snake snake = new Snake(p1, 5, Directions.RIGHT);
            snake.lineDraw();

            FoodCreator foodCreator = new FoodCreator(mapWidth-5, mapHeight-5, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while(true)
            {
                Point head = snake.GetNextPoint();
                if (head.x == mapWidth || head.x == 0 || head.y == mapHeight || head.y == 0 || snake.HitTail())
                {
                    Console.WriteLine("Вы проиграли");
                    break;                    
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
            }


            Console.ReadLine();
        }


    }
}
