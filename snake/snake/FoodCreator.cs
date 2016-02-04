using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int w, int h, char s)
        {
            mapWidth = w;
            mapHeight = h;
            sym = s;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
