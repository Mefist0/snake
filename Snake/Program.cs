using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5,5,'@');
            p1.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 5, 20, '+');
            hLine.Draw();

        }
    }
}
