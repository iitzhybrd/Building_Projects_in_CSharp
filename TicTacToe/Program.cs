string[] grid = new string[9] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
bool isPlayer1Turn = true;
int numTurns = 0;

while (!CheckVictory() && numTurns != 9)
{
    PrintGrid();

    if(isPlayer1Turn)
        Console.WriteLine("Player 1 turn!");
    else
        Console.WriteLine("Player 2 turn!");

    string choice = Console.ReadLine();

    if(grid.Contains(choice) && choice != "X" && choice != "O")
    {
        int gridIndex = Convert.ToInt32(choice) - 1;

        if (isPlayer1Turn)
            grid[gridIndex] = "X";
        else
            grid[gridIndex] = "O";

            numTurns++;
            Console.WriteLine(numTurns);
    }

    isPlayer1Turn = !isPlayer1Turn;
}

if(CheckVictory())
    Console.WriteLine("You Win!");
else
    Console.WriteLine("Tie!");

bool CheckVictory()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
    bool diagUp = grid[6] == grid[4] && grid[4] == grid[2];

    return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
}

void PrintGrid()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(grid[i * 3 + j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine("------");
    }
}