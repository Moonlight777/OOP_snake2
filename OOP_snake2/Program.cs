using System;
using System.Data;
using System.Diagnostics.SymbolStore;

namespace OOP_snake2
{
    class Program
    {
        static void Main(string[] args)
            
        {
           

        Point p1 = new Point(1, 3, '*'); // constructor. That called encapsulation. In object-oriented programming (OOP), encapsulation refers to the bundling of data with the methods that operate on that data, or the restricting of direct access to some of an object's components.[1] Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct access to them. Publicly accessible methods are generally provided in the class (so-called "getters" and "setters") to access the values, and other client classes call these methods to retrieve and modify the values within the object.
            p1.Draw();

            Point p5;

            Point p2 = new Point(4, 5, '%');
            p2.Draw();

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

        }
    }
}
