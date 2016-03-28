using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Line
    {
        Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            pointsList = new List<Point>();
            _direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointsList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pointsList.First();
            pointsList.Remove(tail);
            Point head = GetNextPoint();
            pointsList.Add(head);

            // Очистить старую точку с экрана.
            tail.Clear();
            // Нарисовать новую.
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pointsList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }
    }
}
