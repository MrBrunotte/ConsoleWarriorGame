namespace ConsoleWarriorGame
{
    internal class Map
    {
        private int width;
        private int height;
        // Create a two-dimensional array for the map
        private readonly Cell[,] cells;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;

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
    }
}