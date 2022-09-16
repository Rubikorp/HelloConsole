// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число a");
int a = Int32.Parse(Console.ReadLine()); //Readline возвращает строку, поэтому сделал так
Console.WriteLine("Введите число b");
int b = Int32.Parse(Console.ReadLine());
int max = 0;

if(a < b) {
    max = b;
} else {
    max = a;
}

Console.WriteLine("max = " + max);