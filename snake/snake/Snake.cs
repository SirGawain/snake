using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Direction direction;
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

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
            }
        }
        public bool Eat (Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                mas.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
