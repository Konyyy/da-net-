using System;
using System.Collections.Generic;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру!");

            Player player = new Player();

            while (true)
            {
                Console.WriteLine("\nВведите команду (help для списка команд):");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "help":
                        ShowHelp();
                        break;
                    case "инвентарь":
                        player.ShowInventory();
                        break;
                    case "красть деньги":
                        player.StealMoney();
                        break;
                    case "красть оружие":
                        player.StealWeapon();
                        break;
                    case "магазин":
                        player.EnterShop();
                        break;
                    case "драться":
                        player.Fight();
                        break;
                    case "есть":
                        player.Eat();
                        break;
                    case "спать":
                        player.Sleep();
                        break;
                    case "выход":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Неверная команда. Введите 'help' для списка команд.");
                        break;
                }
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("Список доступных команд:");
            Console.WriteLine("инвентарь - просмотр инвентаря");
            Console.WriteLine("красть деньги - попытаться украсть деньги");
            Console.WriteLine("красть оружие - попытаться украсть оружие");
            Console.WriteLine("магазин - посетить магазин");
            Console.WriteLine("драться - начать бой");
            Console.WriteLine("есть - поесть");
            Console.WriteLine("спать - поспать");
            Console.WriteLine("выход - выйти из игры");
        }
    }

    class Player
    {
        private int health = 100;
        private int money = 50;
        private string weapon = "нож";
        private List<string> inventory = new List<string> { "хлеб", "яблоко" };
        private Shop shop = new Shop();

        public void ShowInventory()
        {
            Console.WriteLine($"Здоровье: {health}");
            Console.WriteLine($"Деньги: {money}");
            Console.WriteLine($"Оружие: {weapon}");
            Console.WriteLine("Инвентарь:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
        }

        public void StealMoney()
        {
            Random rand = new Random();
            int stolenMoney = rand.Next(1, 11);
            money += stolenMoney;
            Console.WriteLine($"Вы украли {stolenMoney} денег!");
        }

        public void StealWeapon()
        {
            string[] weapons = { "меч", "дробовик", "кинжал" };
            Random rand = new Random();
            int index = rand.Next(0, weapons.Length);
            weapon = weapons[index];
            Console.WriteLine($"Вы украли {weapon}!");
        }

        public void EnterShop()
        {
            shop.Browse(this);
        }

        public void Buy(string item, int price)
        {
            if (money >= price)
            {
                money -= price;
                inventory.Add(item);
                Console.WriteLine($"Вы купили {item} за {price} денег!");
            }
            else
            {
                Console.WriteLine("У вас недостаточно денег для покупки!");
            }
        }

        public void Fight()
        {
            Enemy enemy = new Enemy();
            Console.WriteLine($"Вы начали бой с врагом! Враг: {enemy.Name}, Урон: {enemy.Damage}, Здоровье: {enemy.Health}");
            while (health > 0 && enemy.Health > 0)
            {
                enemy.Health -= GetDamage();
                health -= enemy.Damage;
            }
            if (health > 0)
            {
                Console.WriteLine("Вы победили!");
            }
            else
            {
                Console.WriteLine("Вы проиграли!");
            }
        }

        private int GetDamage()
        {
            if (weapon == "нож")
            {
                return 10;
            }
            else if (weapon == "меч")
            {
                return 20;
            }
            else if (weapon == "дробовик")
            {
                return 30;
            }
            else if (weapon == "кинжал")
            {
                return 15;
            }
            else
            {
                return 5; // Базовый урон, если у игрока нет оружия
            }
        }

        public void Eat()
        {
            Random rand = new Random();
            int foodHealth = rand.Next(10, 21);
            health += foodHealth;
            Console.WriteLine($"Вы поели и восстановили {foodHealth} здоровья!");
        }

        public void Sleep()
        {
            health = 100;
            Console.WriteLine("Вы поспали и полностью восстановили здоровье!");
        }
    }

    class Enemy
    {
        public string Name { get; set; } = "Гоблин";
        public int Health { get; set; } = 50;
        public int Damage { get; set; } = 15;
    }

    class Shop
    {
        private Dictionary<string, int> items = new Dictionary<string, int>
        {
            { "меч", 30 },
            { "дробовик", 50 },
            { "хлеб", 5 },
            { "яблоко", 7 }
        };

        public void Browse(Player player)
        {
            Console.WriteLine("Добро пожаловать в магазин!");
            Console.WriteLine("Товары:");

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} - {item.Value} денег");
            }

            Console.WriteLine("Введите название товара для покупки:");
            string itemName = Console.ReadLine().ToLower();

            if (items.ContainsKey(itemName))
            {
                player.Buy(itemName, items[itemName]);
            }
            else
            {
                Console.WriteLine("Такого товара нет в магазине!");
            }
        }
    }
}
