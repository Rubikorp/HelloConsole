//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число: ");
int A = Int32.Parse(Console.ReadLine());
Console.Write("Введите cтепень: ");
int B = Int32.Parse(Console.ReadLine());
int Pow = 1;

for (int i = 0; i < B; i++) {
    Pow = Pow * A;
}

Console.WriteLine(Pow);