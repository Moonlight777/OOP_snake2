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

        public void Draw() // method
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
