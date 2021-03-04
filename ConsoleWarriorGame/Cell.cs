using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWarriorGame
{
    public class Cell: IDrawable
    {
        // create a list for all items on game array and instantiate it
        public List<Item> Items { get; } = new List<Item>();
        public string Symbol => ". ";

        public ConsoleColor Color { get; set; }

        public Cell()
        {
            Color = ConsoleColor.Red;
        }
    }
}
