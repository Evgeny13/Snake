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
            Point p1 = new Point(1, 3, '*'); // конструктор по созданию объекта
            p1.Draw();

            Point p2 = new Point(4, 5, '#');            
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(5, 10, 8, '+');
            hline.Drow();

            WertikalLine wline = new WertikalLine(8, 15, 10, '+');
            wline.Drow();


            Console.ReadLine();
        }
    }
}
//инкапсуляция - свойтсво системы, позволяющее объеденить все данные и методы, работающие с ними в классе и скрыть все детали реализации