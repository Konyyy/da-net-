using System;

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень чилса ");
int y = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < y; i++)
{
    result *= x;
}

Console.WriteLine("Ваше число = " + result);