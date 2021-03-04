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
            var heroCell = map.GetCell(0, 0);
            hero = new Hero(heroCell);
            map.Creatures.Add(hero);
        }

        private void Play()
        {
            // local field
            bool gameInProgress = true;
            do
            {
                // 1) draw map 2) get command 3) execute 4) draw new map 5) enemy actions 6) draw map
                Drawmap();
                // 2) get command
                GetInput();
                // 3) execute
                // 4) draw new map
                Drawmap();

                //Console.ReadKey();
            } while (gameInProgress);
        }

        private void GetInput()
        {
            var keyPressed = UI.GetKey();

            switch (keyPressed)
            {
                case ConsoleKey.LeftArrow:
                    Move(hero.Cell.Y, hero.Cell.X - 1);
                    break;
                case ConsoleKey.RightArrow:
                    Move(hero.Cell.Y, hero.Cell.X + 1);
                    break;
                case ConsoleKey.UpArrow:
                    Move(hero.Cell.Y - 1, hero.Cell.X);
                    break;
                case ConsoleKey.DownArrow:
                    Move(hero.Cell.Y + 1, hero.Cell.X);
                    break;
                default:
                    break;
            }
        }

        private void Move(int y, int x)
        {
            var newPosition = map.GetCell(y, x);
            if (newPosition != null)
            {
                hero.Cell = newPosition;
            }
        }

        private void Drawmap()
        {
            UI.Clear();
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);
                    IDrawable drawable = cell;

                    foreach (var creature in map.Creatures)
                    {
                        if (creature.Cell == cell)
                        {
                            drawable = creature;
                            break;
                        }
                    }
                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}