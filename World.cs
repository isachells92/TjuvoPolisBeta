using System;

namespace TjuvoPolisTest
{
    internal class World
    {
        public string[,] Grid;
        public int Rows;
        public int Cols;

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);
        }

        public void Draw() // Ser du detta?
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    Console.Write(Grid[y, x]);
                }
                Console.WriteLine();
            }
        }
        public bool IsPositionWalkable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Cols || y >= Rows)
            {
                return false;
            }
            // Check bounds first.
            return Grid[y, x] == " " || Grid[y, x] == ". ";
        }


    }
}

//for (int y = 0; y < grid.GetLength(0); y++)                 // Rita spelare och värld.
//{
//    for (int x = 0; x < grid.GetLength(1); x++)
//    {
//        if (px == x && py == y)
//        {
//            string element = "X ";
//            Console.SetCursorPosition(x, y);   // ett annat sätt en ifsatsen för att lokalisera spelare.
//            Console.Write(element);
//            //Console.BackgroundColor = ConsoleColor.Red;
//            //Console.Write("  ");
//            //Console.BackgroundColor = ConsoleColor.Black;
//        }
//        else
//            Console.Write(grid[y, x]);
//    }
//    Console.WriteLine();
//}

