using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите 1 число(до 100) ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число(до 100) ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 100)

    Console.WriteLine("ОШИБКА");
else if (y > 100)
    Console.WriteLine("ОШБИКА");
else {
    int sum;
    sum = 0;
    while (x <= y)
    {
        sum = sum + x;
        x++;
    }
    Console.WriteLine($"Сумма всех чисел = {sum}");
}

