using System;
using System.Collections.Generic;

namespace ConsoleWarriorGame
{
    internal class Map
    {
        public int Width { get; }
        public int Height { get; }
        // Create a two-dimensional array for the map
        private readonly Cell[,] cells;
        public List<Creature> Creatures { get; set; } = new List<Creature>();

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            // cells is just an empty object when instantiatied the for loop sets the cells
            cells = new Cell[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cells[y, x] = new Cell();
                }
            }
        }

        internal Cell GetCell(int y, int x)
        {
            return cells[y, x];
        }
    }
}