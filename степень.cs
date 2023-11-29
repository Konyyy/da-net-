Console.Write("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
double r = 1;
Console.Write("Введите степень: ");
int y = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < y; i++)
{
    r *= x;
}
Console.WriteLine(r);