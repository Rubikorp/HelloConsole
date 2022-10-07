// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillRealNumbersTwoArray(double[,] TwoArray) 
{
    for(int i = 0; i < TwoArray.GetLength(0); i++) 
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            {
                double RealNumber = new Random().NextDouble() * new Random().Next(-10, 10);
                TwoArray[i,j] = Math.Round(RealNumber, 1);
            }
    }
}

void PrintTwoArray(double[,] TwoArray) 
{
    for(int i = 0; i < TwoArray.GetLength(0); i++) 
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            {
                Console.Write($"{TwoArray[i,j]} ");
            }
        Console.WriteLine();    
    }
}

int m = 3;
int n = 4;
double[,] ArrayRealNumbers = new double[m,n];

FillRealNumbersTwoArray(ArrayRealNumbers);
PrintTwoArray(ArrayRealNumbers);
