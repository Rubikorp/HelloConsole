// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите число: ");
int count = 0;

while(true) {
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 111) break;
    if (number > 0) {
        count++;
    }
}
Console.WriteLine($"Кол-во чисел больших 0: {count}");