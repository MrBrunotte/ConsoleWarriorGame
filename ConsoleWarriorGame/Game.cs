using System;

namespace ConsoleWarriorGame
{
    internal class Game
    {
        // private field to make map accessible to the whole class
        private Map map;
        internal void Run()
        {
            Initialize();
            Play();
        }
        private void Initialize()
        {
            //ToDo:  Read from config
            // search for tasklist to find the ToDo task
            //Create a map to play on
            var map = new Map(width: 10, height: 10);
            // Create a Hero player
            var hero = new Hero();
        }

        private void Play()
        {
           
        }

    }
}