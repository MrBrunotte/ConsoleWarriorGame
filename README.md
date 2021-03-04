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
The interface is used to handle different types as something in common
Start by giving the Hero a start position on the map, since we have properites in the Hero class we get a squiggly in the new Hero() in the Initialize(), we start to fix this.
We create a new variablke heroCell in the map with array cells (0,0) as start position, we then set it in the new Hero(heroCell) to set the starting position for the hero.
The logic is: create a variable heroCell that gets kordinates (0,0) => create hero with Hero(heroCell) => Hero inherits from Creature and the sell is set by the constuctor in Creature.
Now we modify the Drawmap() with: 

Console.ForegroundColor = cell?.Color ?? ConsoleColor.White;

The first ? is a null check meaning that if cell is null it will not look for color and if it is not null it will do the action after ?? i.e. change console color to white.
Instead of coding like this we will use the Idrawable interface that we have created.
IDrawable drawable = cell;
In the drawable I can put anything that is inheriting from Creature.

The logic in Drawmap()
We ask the map for a cell with GetCell(y,x) we put it in the class Cell variable cell, the Cell is an IDrawable (Color and Symbol). The IDrawable says "You must have a color and you must have a symbol! Otherwise you are not an IDrawable!" 
We treat the variable cell as an IDrawable called drawable.
We then use the foreach loop to check if the creture is referencing the cell if it does it will overwrite and print the drawable (hero in this case "H").

We need to add hero to the Initialize() method to add it to the map.

Next step - Create GetInput()
Generate UI class in new file and then generate the GetKey(). Make the class static and let the GetKey() be of type ConsoleKey to return the key pressed. The (intercept: key) just captures the pressed key and returns it but does not print it.
Logic => Call the UI and get pressed key with GetKey() method and then use a switch to move correctly according to keypressed.
Next step is to work with the Move(int y, int x) method
GetCell() has a quickfix will be refactored, it returns null if we are outside of the array cells (for now)
We create a Clear() in the UI class that clears the console, makes the curser invisible and sets the curser position to 0,0.

## Commit Four
Start with refactoring the Drawmap() in the Game class
Create Draw(map) and move all code to the Draw(Map map) method in the UI class. We reference the our map in the method Draw(Map map) and when we call the metod in the Game class we have to add the map parameter to the call => Draw(map) 
