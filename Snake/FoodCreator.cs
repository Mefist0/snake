using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random rnd = new Random();

        public FoodCreator(int maxPosX, int maxPosY, char sym)
        {
            this.mapWidth = maxPosX;
            this.mapHeight = maxPosY;
            this.sym = sym;
        } 

        public Point CreateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
