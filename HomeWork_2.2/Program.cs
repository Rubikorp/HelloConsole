Console.Write("Введите число: ");
string numbers = Console.ReadLine();
int length = numbers.Length;
int num = Int32.Parse(numbers);
int[] array = new int[length];
int i = 0;


while (num != 0) {
array[i] = num % 10;

i++;
num /= 10;
};
Array.Reverse(array);

if(array.Length < 3) {
    Console.WriteLine("третьей цифры нет");
} else {
    Console.WriteLine(array[2]);
}
