using System;

class Program
{
    static void Main()

    {
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();
        while (true)
        {

            Console.Write("Повторите пароль: ");
            string repeatPassword = Console.ReadLine();

            while (password != repeatPassword)
            {
                if (repeatPassword.ToLower() == "stop")
                {
                    break;
                }
                Console.WriteLine("Пароли не совпадают. Повторите попытку или введите 'Stop' для выхода.");
                repeatPassword = Console.ReadLine();
            }

            if (repeatPassword.ToLower() == "stop")
            {
               break;
            }

            Console.WriteLine("Пароль успешно введён!");
            break;
        }
    }
}