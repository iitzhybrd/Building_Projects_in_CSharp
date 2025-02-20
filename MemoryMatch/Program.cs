using System;

class MemoryGame
{
    static void Main()
    {
        int rows = 3;
        int cols = 2;

        int asciiStart = 65;
        char[] grid = new char[rows * cols];

        for (int i = 0; i < grid.Length; i++)
            grid[i] = Convert.ToChar(asciiStart + i / 2);

        Random rand = new Random();
        rand.Shuffle(grid); // Implement the Shuffle extension method.

        string[] playingGrid = new string[rows * cols];

        for (int i = 0; i < playingGrid.Length; i++)
            playingGrid[i] = (i + 1).ToString();

        int matches = 0;
        bool gameWon = false;

        while (!gameWon)
        {
            PrintPlayingGrid(playingGrid, rows, cols);

            Console.WriteLine("Please select your first card.");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please select your second card.");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // Validate input
            if (choice1 < 1 || choice1 > rows * cols || 
                choice2 < 1 || choice2 > rows * cols || 
                choice1 == choice2)
            {
                Console.WriteLine("Invalid choices. Please try again.");
                continue;
            }

            // Reveal cards
            playingGrid[choice1 - 1] = grid[choice1 - 1].ToString();
            playingGrid[choice2 - 1] = grid[choice2 - 1].ToString();

            PrintPlayingGrid(playingGrid, rows, cols);

            if (grid[choice1 - 1] == grid[choice2 - 1])
            {
                Console.WriteLine("Match!");
                matches++;

                if (matches == (rows * cols) / 2)
                    gameWon = true;
            }
            else
            {
                Console.WriteLine("No match...");
                playingGrid[choice1 - 1] = (choice1).ToString();
                playingGrid[choice2 - 1] = (choice2).ToString();
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        Console.WriteLine("Congratulations, you win!");
    }

    static void PrintPlayingGrid(string[] playingGrid, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(playingGrid[cols * i + j] + " | ");
            Console.WriteLine();
        }
    }
}

// Extension method for shuffling
public static class Extensions
{
    public static void Shuffle<T>(this Random rng, T[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}