using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Point // class
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw() // method
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
