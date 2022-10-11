// Напишите программу, которая заполнит спирально массив 4 на 4.
void PrintTwoArray(int[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            if (TwoArray[i, j] < 10)
            {
                Console.Write($"0{TwoArray[i, j]} ");
            }
            else
            {
                Console.Write($"{TwoArray[i, j]} ");
            }

        }
        Console.WriteLine();
    }
}
void FillSpiralTwoArray(int[,] matrix)
{
    int n = matrix.GetLength(0) - 1;
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    double visits = n;

    for (int i = 0; i < n * 5 + 1; i++)
    {
        matrix[row, col] = i + 1;
        if (visits-- == 0)
        {
            visits = n * (dirChanges % 2) +
                n * ((dirChanges + 1) % 2) -
                (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
}
int[,] matrix = new int[4, 4];
FillSpiralTwoArray(matrix);
PrintTwoArray(matrix);