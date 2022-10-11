// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void PrintTwoArray(int[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            Console.Write($"{TwoArray[i, j]}({i}, {j}) ");
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
            for (int k = 0; k < TwoArray.GetLength(0); k++)
            {
                for (int m = 0; m < TwoArray.GetLength(1); m++)
                {
                    int count = new Random().Next(10, 99);
                    if(count != TwoArray[k,m])
                    {
                        TwoArray[i,j] = count;
                    }
                }
            }
        }
    }
}

int[,] matrix = new int[4,2];
FillTwoArray(matrix);
PrintTwoArray(matrix);