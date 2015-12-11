using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


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
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT); //p хвост длина 4 направление вправо
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
//инкапсуляция - свойтсво системы, позволяющее объеденить все данные и методы, работающие с ними в классе и скрыть все детали реализации
// абстрагированеие - способ выделить набор значимых характеристик объекта, исключая из рассмотрения незначимые