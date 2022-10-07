// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"({x}; {y})");