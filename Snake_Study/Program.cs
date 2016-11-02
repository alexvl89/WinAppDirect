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

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 1;
            p1.sym = '*';

            Draw(p1.x, p1.y, p1.sym);


            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';

            Draw(p2.x, p2.y, p2.sym);

            Console.ReadLine();
        }



        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
