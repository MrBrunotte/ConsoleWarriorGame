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
Started to setup the Play() method with a do while loop. The Play() will do:
1) drawmap
2) get command
3) execute
4) draw new map
5) enemy action
6) draw map

Added the drawmap() and it draws the map with a nested for loop that uses the map from the Map class (10x10 playing field). The for loops prints out the array cells with the GetCell(y,x) method (note y,x instead x,y!). The loop then writes out the symbol (=> ", ") for each cell, also note that we use Console.Write and not Console.WriteLine (if we did this we would just get a long line.

In the cell class we instantiated a new List for all Itmes and we set a Console color to red.

In the Map class we changed the width and height pubilc properties to Width and Height.
We added a list of Creature and set a default list.
We created the method GetCell() that returns the cells[y,x]

### Inheritance
Creature is the base class and Hero inherits from Creature, we change console color in the Hero constuctor to yellow.

### Interface
We extracted an Interface, from the Creature class, to print out the symbol and color on the console. We selected the public members (prop) color and symbol and named the interface IDrawable. The Interface has both getters and setters.
Since Hero inherits from Creature, it is also a IDrawable meaning that it uses the interface from inheritance!
Cell is also an IDrawable, we need to implement the interface and the IDrawable has the two public members (color, symbol). Cell already had a Symbol property so we add the color property and att it to the constructor (color has get and set in the Interface so we need both).

## Commit Three
