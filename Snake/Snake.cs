using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction) // хвост, длина, направление
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = pList.First(); // возвращает значение первого элемента (в нашем случае конец хвоста)
            pList.Remove(tail); // удалает элемент на конце хвоста
            Point head = GetNextPoint(); // дает следующую точку в направлении движения
            pList.Add(head); // добавляет элемент в направлении движения

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last(); // позиция головы змейки до перемещения
            Point nextPoint = new Point(head); //
            nextPoint.Move(1, direction); //сдвигаем точку в направление direction на расстояние 1
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;

        }

    }
}
// змейка - фигура на карте, состоящая из точек, имеет стартовую позицию на карте, находится в каких-то координатах и будет двигаться в каком-то направлении