// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[size];
FillArrayRandomarr(arr);
Console.WriteLine("Вот наш массив: ");
PrintArray(arr);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] > max)
        {
            max = arr[index];
        }
    if (arr[index] < min)
        {
            min = arr[index];
        }
}

Console.WriteLine($"всего {arr.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomarr(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}