using System;

namespace Test
{
    public class FoodCreator
    {
        public int mapWidht;
        public int mapHeight;
        public char sym;
        
        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht -2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);

        }
    }
}