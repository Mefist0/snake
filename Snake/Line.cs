﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line
    {
        protected List<Point> pointsList;

        public void Draw()
        {
            foreach (Point p in pointsList)
            {
                p.Draw();
            }
        }
    }
}
