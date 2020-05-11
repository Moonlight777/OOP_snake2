using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Figure // That class has OOP pr. of inheritance
    {

       protected  List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
