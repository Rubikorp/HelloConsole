// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintTwoArray(int[,] TwoArray) 
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
void FillTwoArray(int[,] TwoArray) 
{
    for(int i = 0; i < TwoArray.GetLength(0); i++) 
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            {   
                TwoArray[i,j] = new Random().Next(0, 10);
            }
    }
}
void FindNumberTwoArray(int[,] TwoArray, int Number)
{
    bool FindNumber = false;
    for(int i = 0; i < TwoArray.GetLength(0); i++) 
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            if (TwoArray[i,j] == Number) 
            {
                Console.Write($"Число {Number} есть в массиве");
                FindNumber = true;
                break;
            }
         }
         if(FindNumber == true) // Чтобы повторно не вывел мне запись, если число не одно
         {
            break;
         }
    }
    if (FindNumber == false)  
    {
        Console.Write($"Числа {Number} нет в массиве");
    }
}

int[,] matr = new int[3,4];
Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
FillTwoArray(matr);
PrintTwoArray(matr);
FindNumberTwoArray(matr, number);