using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> mas;

        public void Draw()
        {
            foreach (Point p in mas)
                p.Draw();
        }

        public bool IsHit(Figure figure)
        {
            foreach (var p in mas)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit (Point point)
        {
            foreach (var p in mas)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
