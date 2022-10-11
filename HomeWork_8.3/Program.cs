//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void PrintTwoArray(int[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            Console.Write($"{TwoArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MultipleMatrix(int[,] ResultMatr, int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); ++i)
    {
        for (int j = 0; j < matr2.GetLength(0); ++j) 
        {
            for (int k = 0; k < matr2.GetLength(1); ++k) 
            {
                ResultMatr[i, k] += matr1[i, j] * matr2[j, k];
            }
        }
    }                       
}

int[,] Matrix1 = new int[,] 
{
    {2, 4},
    {3, 2}
};
int[,] Matrix2 = new int[,] 
{
    {3, 4},
    {3, 3}
};
int[,] ResultMatrix = new int[2,2];
MultipleMatrix(ResultMatrix, Matrix1, Matrix2);
PrintTwoArray(ResultMatrix);