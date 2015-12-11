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

        public void Draw()
        {
            Console.SetCursorPosition(x, y); // выводит точку с координатами
            Console.Write(sym); // отображает символ
        }
    }
}
