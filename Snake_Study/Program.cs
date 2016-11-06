using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;

namespace Snake_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 80;
            int y = 25;
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);

            Walls walls = new Walls(x, y);
            walls.Draw();


            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            //while (true)
            //{
            //    if (snake.Eat(food))
            //    {
            //        food = foodCreator.CreateFood();
            //        food.Draw();                    
            //    }
            //    else
            //    {
            //        snake.Move();
            //    }
            //    Thread.Sleep(300);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.HandlKey(key.Key);
            //    }

            //}

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }

            }

            // Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
            figure.Drow();
        }

    }
}
