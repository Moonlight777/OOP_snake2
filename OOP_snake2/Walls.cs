using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake2
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Drawing borders
            HorizontallLine upLine = new HorizontallLine(0, mapWidth - 2, 0, '+');
            HorizontallLine downLine = new HorizontallLine(0, mapWidth - 2, mapHeight -1, '+');
            Verticalline leftLine = new Verticalline(0, mapHeight - 1, 0, '+');
            Verticalline rightLine = new Verticalline(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
                return false;
            }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
