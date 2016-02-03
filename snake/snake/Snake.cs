using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            mas = new List<Point>();
            for(int i=0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                mas.Add(p);
            }
        }
        public void Move()
        {
            Point tail = mas.First();
            mas.Remove(tail);
            Point head = GetNextPoint();
            mas.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = mas.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
