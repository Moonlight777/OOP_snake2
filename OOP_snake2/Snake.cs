using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction) // Abstruction
        {
            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
