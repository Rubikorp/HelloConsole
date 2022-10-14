// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunc(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return AckermanFunc(m - 1, 1);
            }
            else
            {
                return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
            }
 
        }

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermanFunc(m, n));