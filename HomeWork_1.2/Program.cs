// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число a: ");
int a = Int32.Parse(Console.ReadLine()); 
Console.Write("Введите число b: ");
int b = Int32.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Int32.Parse(Console.ReadLine());

int max = 0;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);