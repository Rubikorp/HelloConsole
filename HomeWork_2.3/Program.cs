//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: ");
int day = Int32.Parse(Console.ReadLine());
int[] week = new int[7];
int index = 0;
int i = 0;

while (index < week.Length) {
    week[index] = index + 1;
    index++;
}
if (day < 6) {
    Console.WriteLine("Будни");
} else {
    while (i < week.Length) {
        if (day == week[i] && week[i] == 6){
            Console.WriteLine("Выходной");
            break;
        } else if(day == week[i] && week[i] == 7){
            Console.WriteLine("Выходной");
            break;
        }
        i++;
    }
}



