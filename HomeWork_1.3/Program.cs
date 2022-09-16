//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine()); 

if (number % 2 == 0) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
