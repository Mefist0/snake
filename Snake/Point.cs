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

        public Point(int x, int y, char sym)
        {
            this._x = x;
            this._y = y;
            this._sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }
    }
}
