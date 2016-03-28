using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            // Нарисовать границы поля.
            HorizontalLine topWall = new HorizontalLine(0, 0, 78, '+');
            topWall.Draw();
            HorizontalLine bottomWall = new HorizontalLine(0, 24, 78, '+');
            bottomWall.Draw();
            VerticalLine leftWall = new VerticalLine(0, 0, 24, '+');
            leftWall.Draw();
            VerticalLine rightWall = new VerticalLine(78, 1, 22, '+');
            rightWall.Draw();

            // Создать еду для змейки.
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Отображение змейки.
            Point startPos = new Point(10, 10, '*');
            Snake snake = new Snake(startPos, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandle(key.Key);
                }
                Thread.Sleep(100);
            }
        }
    }
}
