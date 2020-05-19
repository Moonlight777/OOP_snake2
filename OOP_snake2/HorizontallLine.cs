using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOP_snake2
{
    class HorizontallLine : Figure // That's inharitance
    {
        public HorizontallLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }


        }
        
      }
 }

