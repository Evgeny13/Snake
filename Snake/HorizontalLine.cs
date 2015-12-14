using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Drow(); // вызывается метод Drow из базового класса, в данном случае Figure

            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
