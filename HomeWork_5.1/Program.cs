// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите длину массива: ");
int size = Int32.Parse(Console.ReadLine());
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
PrintArray(arr);
int count = 0;

for (int index = 0; index < arr.Length; index++) {
    if (arr[index] % 2 == 0) {
        count++;
    }
}

Console.WriteLine($"всего {arr.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] Arr)
{
    for(int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] Arr)
{
    Console.Write("[ ");
    for(int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}