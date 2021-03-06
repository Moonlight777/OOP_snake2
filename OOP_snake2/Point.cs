﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Point // class
    {
        public int x; // data
        public int y;
        public char sym;

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
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }

        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
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

        public void Reset(Point p)
        {
            p = new Point(); // that will not reset ram cause it's just a duplicate of variable
           
        }

    }
}
