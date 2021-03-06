﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xPos, int yPos, int length, char sym)
        {
            pointsList = new List<Point>();
            for(int i = xPos; i <= xPos + length; i++)
            {
                Point p = new Point(i, yPos, sym);
                pointsList.Add(p);
            }
        }
    }
}
