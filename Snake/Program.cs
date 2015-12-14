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

            Walls walls = new Walls(80, 25);
            walls.Drow();

            // отрисовка точек            
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT); //p хвост длина 4 направление вправо
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$'); // класс чтобы появилась еда
            Point food = foodCreator.CreatorFood();
            food.Drow();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                    if (snake.Eat(food))
                {
                    food = foodCreator.CreatorFood();
                    food.Drow();
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