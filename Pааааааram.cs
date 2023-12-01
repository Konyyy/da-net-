using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Вводите любые числа, а после того как законичите введите 0 и программа посчитает сумму всех чисел которые вы ввели ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0)
{
    sum += num;
    Console.WriteLine("Введите ещё число а если хотите закончить введите число 0");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(sum);

