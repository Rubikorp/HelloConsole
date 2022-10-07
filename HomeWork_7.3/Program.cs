//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void PrintArithmeticMeanColumnTwoArray(int[,] TwoArray)
{
    double[] arr = new double[TwoArray.GetLength(1)];
    double summ = 0;

    for (int i = 0; i < TwoArray.GetLength(1); i++) //столбцы
    {
        for (int j = 0; j < TwoArray.GetLength(0); j++) //строки
        {
            summ = summ + TwoArray[j, i];
        }
        double ArithmeticMean = summ / TwoArray.GetLength(0);
        arr[i] = Math.Round(ArithmeticMean, 1);
        summ = 0;
    }
    for (int n = 0; n < arr.Length; n++)
    {
        Console.Write($"{arr[n]} ");
    }
}

int[,] matr = new int[3, 4];
FillTwoArray(matr);
PrintTwoArray(matr);
Console.WriteLine();
PrintArithmeticMeanColumnTwoArray(matr);
