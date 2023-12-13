using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начало диапазона: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите конец диапазона: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Введите число при котором программа остановится: ");
        int z = int.Parse(Console.ReadLine());

        Random random = new Random();
        int generatedNumber;

        do
        {
            generatedNumber = random.Next(x, y + 1);
            Console.WriteLine("Сгенерированное число: " + generatedNumber);
        }
        while (generatedNumber != z);

        Console.WriteLine("Сгенерировано число " + z + ".");
    }
}