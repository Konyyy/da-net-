using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Console.Write("Введите минимальное число: ");
        int minNumber = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное число: ");
        int maxNumber = int.Parse(Console.ReadLine());
        int numberToGuess = random.Next(minNumber, maxNumber + 1);
        int attempts = 0;
        bool isCorrectGuess = false;

        Console.WriteLine("Добро пожаловать в игру \"Отгадай число\"!");
        Console.WriteLine($"Я загадал число от {minNumber} до {maxNumber}. Попробуйте угадать.");

        while (!isCorrectGuess)
        {
            Console.Write("Введите вашу догадку: ");
            string input = Console.ReadLine();

            bool isValidNumber = int.TryParse(input, out int guessedNumber);
            if (!isValidNumber || guessedNumber < minNumber || guessedNumber > maxNumber)
            {
                Console.WriteLine("Неверный ввод. Введите число из заданного диапазона.");
                continue;
            }

            attempts++;

            if (guessedNumber == numberToGuess)
            {
                isCorrectGuess = true;
                Console.WriteLine($"Поздравляю! Вы угадали число {numberToGuess} за {attempts} попыток.");
            }
            else if (guessedNumber < numberToGuess)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }

        Console.WriteLine("Спасибо за игру.");
    }
}