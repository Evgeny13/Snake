using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sum;

        public void Draw()
        {
            Console.SetCursorPosition(x, y); // выводит точку с координатами
            Console.Write(sum);
        }
    }
}
