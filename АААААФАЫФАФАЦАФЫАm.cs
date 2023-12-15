using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int[] da = new int[x];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < x; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            da[i] = Convert.ToInt32(Console.ReadLine());
        }

        int polozytelyno = 0;
        int otrizatelyno = 0;

        foreach (int number in da)
        {
            if (number > 0)
                polozytelyno++;
            else if (number < 0)
                otrizatelyno++;
        }

        Console.WriteLine($"Количество положительных чисел: {polozytelyno}");
        Console.WriteLine($"Количество отрицательных чисел: {otrizatelyno}");
    }
}