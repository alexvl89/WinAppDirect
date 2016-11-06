using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Study
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();

            //отризовка рамки
            HorizontalLine upline = new HorizontalLine(0, mapWidht-2, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, mapWidht-2, mapHeight-1, '+');
            VerticalLine leftline = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine rigthline = new VerticalLine(0, mapHeight-1, mapWidht-2, '+');
            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rigthline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Drow();
            }
        }

    }
}