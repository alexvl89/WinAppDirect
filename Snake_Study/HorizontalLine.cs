using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Study
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>(); 
            for (int x=xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


        }



        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }

        }

    }
}
