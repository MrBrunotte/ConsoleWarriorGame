# ConsoleWarriorGame

This is an exercise in building a consol game called "ConsolWarriorGame"

## Inital Classes

Starting with brainstorming classes

- Player Hero
- Abstract Items base Portion
- Points
- Enemy, Monster
- Map - Cell
- Gamestate, (log)
- UI
- Postion
- Game (keeps the loop)

## Commit One

I created the classes:
- Game
- Hero
- Map
- Cell

### Game class
A private field Map was made to make the Map() reachable in the whole Game class

From the Game class i created the Initalize method that initalizes the game with a map to play on and a new Hero player. The Map() and Hero() was create by CTRL + . them!
The Map was initialized with the properties width: 10 and height: 10

### Map class
A private readonly field for the array was made the array was named cells
The cell object was initialized with the parameters height and widtyh and a nested for loop was used to instantiate the array cells

## Commit Two
