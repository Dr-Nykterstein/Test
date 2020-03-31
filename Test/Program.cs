using System;
using System.Collections.Generic;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300); 
            snake.Move();
            Thread.Sleep(300); 
            snake.Move();
            Thread.Sleep(300); 
            snake.Move();
            Thread.Sleep(300);
            // Point p2 = new Point(4, 5, '$');
            // p2.Draw();
            
            HorizontalLine line = new HorizontalLine(5, 10, 8, '-');
            line.Draw();
            
            VerticalLine lineV = new VerticalLine(4, 10, 1, '|');
            lineV.Draw();
            Console.ReadLine();
        }
    }
}