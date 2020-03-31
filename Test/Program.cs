﻿using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
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