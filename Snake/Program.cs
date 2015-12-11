using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            WertikalLine leftLine = new WertikalLine(0, 24, 0, '+');            
            WertikalLine righrLine = new WertikalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            righrLine.Drow();


            // отрисовка точек
            Point p1 = new Point(1, 3, '*'); // конструктор по созданию объекта
            p1.Draw();

            Point p2 = new Point(4, 5, '#');            
            p2.Draw();

            // препятствия
            HorizontalLine hline = new HorizontalLine(5, 10, 8, '+');
            hline.Drow();

            WertikalLine wline = new WertikalLine(8, 15, 10, '+');
            wline.Drow();


            Console.ReadLine();
        }
    }
}
//инкапсуляция - свойтсво системы, позволяющее объеденить все данные и методы, работающие с ними в классе и скрыть все детали реализации