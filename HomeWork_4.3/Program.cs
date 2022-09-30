//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Write("Введите длину массива: ");
int length = Int32.Parse(Console.ReadLine());
int[] arr = new int[length];

for(int i = 0; i < length; i++) {
    Console.Write($"Введите число №{i + 1}: ");
    arr[i] = Int32.Parse(Console.ReadLine());
}

Console.Write("Ваш массив: [");
for(int index = 0; index < arr.Length; index++) {
    if(index == arr.Length - 1) {
        Console.Write($"{arr[index]}");
    } else {
        Console.Write($"{arr[index]}, ");
    }
}
Console.Write("]");
