using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int _x;
        public int _y;
        public char _sym;

        public Point(Point point)
        {
            _x = point._x;
            _y = point._y;
            _sym = point._sym;
        }

        public Point(int x, int y, char sym)
        {
            this._x = x;
            this._y = y;
            this._sym = sym;
        }

        public void Clear()
        {
            _sym = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    _x -= offset;
                    break;
                case Direction.RIGHT:
                    _x += offset;
                    break;
                case Direction.UP:
                    _y -= offset;
                    break;
                case Direction.DOWN:
                    _y += offset;
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }
    }
}
