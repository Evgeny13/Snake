using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class WertikalLine
    {
        List<Point> pList;

        public WertikalLine(int yVerh, int yNis, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yVerh; y <= yNis; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
