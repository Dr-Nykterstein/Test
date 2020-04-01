using System;
using System.Collections.Generic;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '-');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '|');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw(); 
            
            Point p1 = new Point(15, 15, '*');
            Snake snake = new Snake(p1, 4, Direction.Right);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (snake.Eat(food))
                {
                    food.Draw();
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                Thread.Sleep(1500);
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);  
                }
                
                snake.Move();
            }
            
            
            
            
            Console.ReadLine();
        }
    }
}