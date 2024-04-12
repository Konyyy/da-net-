using System;
using System.IO;

namespace MovieCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Введите команду (для помощи введите 'Help'):");
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "HELP":
                        ShowHelp();
                        break;
                    case "A":
                        AddMovie();
                        break;
                    case "R":
                        RemoveMovie();
                        break;
                    case "I":
                        ShowMovieInfo();
                        break;
                    case "AI":
                        AddMovieInfo();
                        break;
                    case "SAF":
                        ShowAllMovies();
                        break;
                    case "OFF":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("A - добавить фильм");
            Console.WriteLine("R - удалить фильм");
            Console.WriteLine("I - посмотреть детали фильма (дата выхода и режиссёр)");
            Console.WriteLine("AI - добавить информацию о фильме (дата выхода и режиссёр)");
            Console.WriteLine("SAF - просмотреть все фильмы");
            Console.WriteLine("OFF - выключить программу");
        }

        static void AddMovie()
        {
            Console.WriteLine("Введите название фильма:");
            string movieTitle = Console.ReadLine();

            // новый фильм в файл
            using (StreamWriter writer = File.AppendText("movies.txt"))
            {
                writer.WriteLine(movieTitle);
            }
        }

        static void RemoveMovie()
        {
            Console.WriteLine("Введите название фильма, который хотите удалить:");
            string movieTitle = Console.ReadLine();

            // снос фильма из файла
            var file = new List<string>(File.ReadAllLines("movies.txt"));
            file.Remove(movieTitle);
            File.WriteAllLines("movies.txt", file.ToArray());
        }

        static void ShowMovieInfo()
        {
            Console.WriteLine("Введите название фильма, о котором хотите узнать:");
            string movieTitle = Console.ReadLine();

            // поиск фильма в файле и вывод информации
            string[] movies = File.ReadAllLines("movies.txt");
            foreach (string movie in movies)
            {
                if (movie.Contains(movieTitle))
                {
                    Console.WriteLine("Дата выхода: ");
                    // добавить код для вывода даты выхода фильма
                    Console.WriteLine("Режиссёр: ");
                    // добавить код для вывода режиссёра
                    return;
                }
            }
            Console.WriteLine("Фильм не найден");
        }

        static void AddMovieInfo()
        {
            Console.WriteLine("Введите название фильма, к которому хотите добавить информацию:");
            string movieTitle = Console.ReadLine();

            // dобавление информации о фильме в файл
            string[] movies = File.ReadAllLines("movies.txt");
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Contains(movieTitle))
                {
                    Console.WriteLine("Введите дату выхода фильма:");
                    string releaseDate = Console.ReadLine();
                    // добавить запись даты выхода фильма в файл

                    Console.WriteLine("Введите режиссёра фильма:");
                    string director = Console.ReadLine();
                    // добавить запись режиссёра фильма в файл

                    return;
                }
            }
            Console.WriteLine("Фильм не найден");
        }

        static void ShowAllMovies()
        {
            string[] movies = File.ReadAllLines("movies.txt");
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}