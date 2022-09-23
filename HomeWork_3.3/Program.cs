//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int n = 1;

while (n <= number) {
    Console.WriteLine(Math.Pow(n,3));
    n++;
}