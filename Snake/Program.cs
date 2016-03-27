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

            Console.SetBufferSize(80, 25);

            HorizontalLine topWall = new HorizontalLine(0, 0, 78, '+');
            topWall.Draw();
            HorizontalLine bottomWall = new HorizontalLine(0, 24, 78, '+');
            bottomWall.Draw();
            VerticalLine leftWall = new VerticalLine(0, 0, 24, '+');
            leftWall.Draw();
            VerticalLine rightWall = new VerticalLine(78, 1, 22, '+');
            rightWall.Draw();

            Console.ReadLine();
        }
    }
}
