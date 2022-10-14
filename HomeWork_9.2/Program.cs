// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SumTwoNumber(int min, int max)
{
    int sum = 0;
    for (int i = min; i <= max; i++)
    {
        sum = sum + min;
        min++;
    }
    Console.WriteLine(sum);
}

Console.Write("Введите минимальное число: ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int Max = Convert.ToInt32(Console.ReadLine());

SumTwoNumber(Min, Max);
