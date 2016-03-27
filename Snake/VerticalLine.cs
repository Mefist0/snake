using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Line
    {
        public VerticalLine(int xPos, int yPos, int length, char sym)
        {
            pointsList = new List<Point>();
            for (int i = yPos; i <= yPos + length; i++)
            {
                Point p = new Point(xPos, i, sym);
                pointsList.Add(p);
            }
        }
    }
}
