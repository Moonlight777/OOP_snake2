using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace OOP_snake2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.SetWindowSize(1, 1); // Windows size
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            /*    Point p1 = new Point(1, 3, '*'); // constructor. That called encapsulation. In object-oriented programming (OOP), encapsulation refers to the bundling of data with the methods that operate on that data, or the restricting of direct access to some of an object's components.[1] Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct access to them. Publicly accessible methods are generally provided in the class (so-called "getters" and "setters") to access the values, and other client classes call these methods to retrieve and modify the values within the object.
                p1.Draw();

                Point p2 = new Point(4, 5, '%'); // Point is an object
                p2.Draw();
            */
            // Drawing borders
            HorizontallLine upLine = new HorizontallLine(0, 78, 0, '+');
            HorizontallLine downLine = new HorizontallLine(0, 78, 24, '+');
            Verticalline leftLine = new Verticalline(0, 24, 0, '+');
            Verticalline rightLine = new Verticalline(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            // Drawing Points

            Point p = new Point(4, 5, '*');
            // p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();


            }
        }
    }
}





        /*    snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

        */

            /*  HorizontallLine line = new HorizontallLine(5, 10, 8, '+');
              line.Draw();

              Verticalline line2 = new Verticalline(7, 12, 10,'$');
              line2.Draw();
            */
   

         /*   List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0); // remove something from list

            List<char> charList = new List<char>();
            charList.Add('&');
            charList.Add('^');
            charList.Add('%');

            char x4 = charList[0];
            char x2 = charList[1];
            char x3 = charList[2];

            Console.WriteLine(x3);


            Point p10 = new Point(7,7,'$');
            p10.Draw();

            Point p11 = new Point(6, 6, '(');
            p11.Draw();

            Point p12 = new Point(8, 8, ')');
            p12.Draw();

            Point p13 = new Point(9, 9, '^');
            p13.Draw();

            List<Point> p2List = new List<Point>();
            p2List.Add(p10);
            p2List.Add(p11);
            p2List.Add(p12);
            p2List.Add(p13);


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.WriteLine(pList);

           */




          //  Console.WriteLine(p1);

          //  Point(1,3,'^') = pList[p1];


         /*   foreach (Point i2 in pList)
            {
                Console.WriteLine(i2);
            }




            Console.ReadLine();


/* Homework for RAM lesson
 * 
            Point p3 = new Point(9, 12, '$');
        //    p3 = Point.Create();
            p3.Draw();

            Point value = new Point(8 ,6,'(');
            value.Draw();

            Point p4 = new Point(10, 10, '^'); // Move point witn function Move
            p4.Move(p4, 15, 15);
            p4.Draw();

          //  Console.WriteLine("Reset");
            p5 = new Point(20,25,'@'); // Reset of p5
            p5.Reset(p5);
          //  Point.Reset(p5);
          //  Console.WriteLine("x = " + p5.x + " y = " + p5.y);
            p5.Draw();

            Console.ReadLine();

*/
            /*  p1.x = 1;
          p1.y = 3;
          p1.sym = '*'; */



            /*   p2.x = 4;
            p2.y = 5;
            p2.sym = '%'; */


            //    Draw(p1.x, p1.y, p1.sym);
            //    Draw(p2.x, p2.y, p2.sym);
            //    Console.WriteLine("Hello World!");
            //    Console.WriteLine();

            /*  int x1 = 1;
              int y1 = 3;
              char sym1 = '*';


              Draw(x1, y1, sym1); */

            // Console.SetCursorPosition(x1, y1);
            // Console.Write(sym1);

            /*   int x2 = 4;
               int y2 = 5;
               char sym2 = '%';

               // Console.SetCursorPosition(x2, y2);
               // Console.Write(sym2);

               Draw(x2, y2, sym2); */

            /*   static void Draw(int x, int y, char sym)

       {
           Console.SetCursorPosition(x, y);
           Console.Write(sym);

       }

      */
