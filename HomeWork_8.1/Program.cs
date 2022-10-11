//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void FillTwoArray(int[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = new Random().Next(1, 10);
        }
    }
}
void SortTwoArray(int[,] TwoArray) 
{
    int max = 0;
    for (int i = TwoArray.GetLength(0); i >= 0; i--)
    {
        for (int j = TwoArray.GetLength(1)-2; j >= 0; j--)
        {
            for (int k = TwoArray.GetLength(0); k >= 0 ; k--)
            {
                for (int m = TwoArray.GetLength(1)-2; m >= 0; m--)
                {
                    if(TwoArray[j, i] < TwoArray[m, k])
                    {
                        max = TwoArray[m, k];
                        TwoArray[m, k] = TwoArray[j, i];
                        TwoArray[j, i] = max;
                    }
                }
            }
        }
    }
}

int[,] matr = new int[3,4];
FillTwoArray(matr);
PrintTwoArray(matr);
Console.WriteLine();
SortTwoArray(matr);
PrintTwoArray(matr);