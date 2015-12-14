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
            /*  Console.SetBufferSize(80, 25);

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

              FoodCreator foodCreator = new FoodCreator(80, 25, '$'); // класс чтобы появилась еда
              Point food = foodCreator.CreatorFood();
              food.Draw();*/
            WertikalLine v1 = new WertikalLine(0, 10, 5, '%');
            Drow(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Drow(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)
            {
                f.Drow();
            }

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreatorFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

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