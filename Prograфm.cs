using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введенный массив:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: {array[i]}");
        }
    }
}