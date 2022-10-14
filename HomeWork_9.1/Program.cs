// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int NumbersNatural(int count)
{
    Console.Write($"{count} ");
    if(count == 1) return count = 1;
    else return NumbersNatural(count - 1);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersNatural(number);