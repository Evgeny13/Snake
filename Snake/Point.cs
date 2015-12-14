using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x; // координата х
        public int y; // координата у
        public char sym; // символ (.)

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p) // конструктор точки
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction) // сдвигает точку на расстояние offset по направлению direction
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Drow()
        {
            Console.SetCursorPosition(x, y); // выводит точку с координатами
            Console.Write(sym); // отображает символ
        }

        public void Clear()
        {
            sym =' ';
            Drow();
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
