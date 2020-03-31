using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symb1 = '*';
            
            Console.SetCursorPosition(x1, y1);
            Console.Write(symb1);
            
            
            int x2 = 4;
            int y2 = 5;
            char symb2 = '#';
            
            Draw(x2, y2, symb2);
            
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
    }
}