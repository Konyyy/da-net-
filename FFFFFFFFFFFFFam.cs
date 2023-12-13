using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sn = GetDigitCount(number);

        Console.WriteLine($"Количество цифр в числе: {sn}");
;
    }

    static int GetDigitCount(int number)
    {
        int i = 0;

       
        if (number == 0)
        {
            i = 1;
        }
        else
        {
       
            if (number < 0)
            {
                number = -number;
            }


            while (number > 0)
            {
                number /= 10;
                i++;
            }
        }

        return i;
    }
}