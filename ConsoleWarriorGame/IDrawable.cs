using System;

namespace ConsoleWarriorGame
{
    public interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}