using System;

namespace Test
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            else
            {
                y = y - offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
    }
}
   