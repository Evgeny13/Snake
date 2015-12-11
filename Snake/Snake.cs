using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction) // хвост, длина, направление
        {
            pList = new List<Point>();
            for (int i = 0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
// змейка - фигура на карте, состоящая из точек, имеет стартовую позицию на карте, находится в каких-то координатах и будет двигаться в каком-то направлении