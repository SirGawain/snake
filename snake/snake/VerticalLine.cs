using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> mas;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            mas = new List<Point>();
            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                mas.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in mas)
                p.Draw();
        }
    }
}
