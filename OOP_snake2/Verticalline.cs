using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Verticalline : Figure // That's inharitance
    {
        public Verticalline(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
