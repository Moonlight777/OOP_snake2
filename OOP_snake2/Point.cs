using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Point // class
    {
        public int x; // data
        public int y;
        private char sym;

        public Point() // constructor
        {
        }

        public Point(int _x, int _y, char _sym) // constructor2
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
    
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }

        }

        public void Draw() // method for Points
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    
        public void Func1(int value)
        {
            value = value + 1; // X will be +1
        }

     /*   public void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

    */
        public void Reset(Point p)
        {
            p = new Point(); // that will not reset ram cause it's just a duplicate of variable
           
            //// p.x = 0; // that will reset ram to null
           //   p.y = 0;
           // Console.WriteLine("Resetting");
           // Console.WriteLine("new x = " + p.x + " new y = " + p.y);
           
        }

    }
}
