using System;

namespace ConsoleWarriorGame
{
    internal class Game
    {
        // private field to make map accessible to the whole class
        private Map map;
        private Hero hero;

        internal void Run()
        {
            Initialize();
            Play();
        }
        private void Initialize()
        {
            //ToDo:  Read from config
            // search for tasklist to find the ToDo task, and a Hero
            map = new Map(width: 10, height: 10);
            hero = new Hero();
        }

        private void Play()
        {
            // local field
            bool gameInProgress = true;
            do
            {
                // 1) draw map 2) get command 3) execute 4) draw new map 5) enemy actions 6) draw map
                Drawmap();

                Console.ReadKey();
            } while (gameInProgress);
        }

        private void Drawmap()
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);
                    Console.Write(cell.Symbol);
                }
                Console.WriteLine();
            }
        }
    }
}