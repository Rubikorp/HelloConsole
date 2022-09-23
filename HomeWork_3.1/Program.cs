// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int[] arr = new int[5];
int index = 0;

while (index < arr.Length) {
    arr[index] = number % 10;
    number = number / 10; 

    index++;
}

if (arr[4] == arr[0] && arr[1] == arr[3]) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}


