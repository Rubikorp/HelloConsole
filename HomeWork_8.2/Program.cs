//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void PrintMinSummStrokeTwoArray(int[,] TwoArray)
{
    int[] AllSumm = new int[TwoArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            sum = sum + TwoArray[i,j];
            if(j == 3) {
                AllSumm[i] = sum;
                sum = 0;
            }
        }
    }
    int MinSumm = AllSumm[0];
    int IndexStroke = 0;
    for (int k = 0; k < AllSumm.Length; k++)
    {
        if(AllSumm[k] < MinSumm)
        {
            MinSumm = AllSumm[k];
            IndexStroke = k+1;
        }
    }
    Console.WriteLine(IndexStroke);
}

int[,] matrix = new int[4,4];
FillTwoArray(matrix);
PrintTwoArray(matrix);
Console.WriteLine();
PrintMinSummStrokeTwoArray(matrix);
