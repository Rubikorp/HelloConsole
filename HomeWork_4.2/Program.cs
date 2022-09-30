// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
string number = Console.ReadLine();
int[] arr = new int[number.Length];
int num = Int32.Parse(number);
int index = 0;
int i = 0;
int summ = 0;

while (index < arr.Length) {
    arr[index] = num % 10;
    num = num / 10;
    index ++;
}

while (i < arr.Length) {
    summ = summ + arr[i];
    i++;
}

Console.WriteLine(summ);
