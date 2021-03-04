﻿using System;

namespace ConsoleWarriorGame
{
    internal class Hero : Creature
    {
        public Hero(Cell cell) : base(cell, "H")
        {
            Color = ConsoleColor.Yellow;
        }
    }
}