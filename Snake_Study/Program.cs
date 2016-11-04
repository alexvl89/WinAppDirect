using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

 
            //отризовка рамки
            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine rigthline = new VerticalLine(78, 0, 24, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rigthline.Drow();

            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();


            Console.ReadLine();
        }



    }
}
