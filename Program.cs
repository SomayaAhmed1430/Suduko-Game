

using Suduko;

int[,] sudokuMatrix = new int[9, 9]
{
    {5, 3, 0, 0, 7, 0, 0, 0, 0},
    {6, 0, 0, 1, 9, 5, 0, 0, 0},
    {0, 9, 8, 0, 0, 0, 0, 6, 0},
    {8, 0, 0, 0, 6, 0, 0, 0, 3},
    {4, 0, 0, 8, 0, 3, 0, 0, 1},
    {7, 0, 0, 0, 2, 0, 0, 0, 6},
    {0, 6, 0, 0, 0, 0, 2, 8, 0},
    {0, 0, 0, 4, 1, 9, 0, 0, 5},
    {0, 0, 0, 0, 8, 0, 0, 7, 9}
};

var suduko = new SudukoGame(sudokuMatrix);

while (!suduko.IsComplete())
{
    Console.Clear();
    suduko.PrintGrid();

    Console.WriteLine("\nEnter row (1-9)");
    int row = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("\nEnter column (1-9)");
    int col = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("\nEnter number (1-9)");
    int num = int.Parse(Console.ReadLine());

    if (suduko.IsValidMove(row, col, num))
    {
        suduko.MakeMove(row, col, num);   
    }
    else
    {
        Console.WriteLine("Invalid move! Press any key to try again...");
        Console.ReadKey();
    }
}

Console.Clear();
suduko.PrintGrid();
Console.WriteLine("Congratulations! You've completed the Sudoku.");