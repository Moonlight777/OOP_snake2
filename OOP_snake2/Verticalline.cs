using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Verticalline
    {
        List<Point> pList;
        public Verticalline(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
