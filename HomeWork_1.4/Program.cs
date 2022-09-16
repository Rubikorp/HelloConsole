//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine()); 
int count = 0;

while (count < number - 1) {
    count += 2;
    Console.Write(count + " ");
}
