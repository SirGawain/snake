using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> mas;

        public HorizontalLine (int xL, int xR, int y, char sym)
        {
            mas = new List<Point>();
            for(int x= xL; x<= xR; x++)
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
