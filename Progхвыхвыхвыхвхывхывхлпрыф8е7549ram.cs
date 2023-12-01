Console.WriteLine("Вводите любые числа, а после того как сумма всех чисел достигнет 100 программа прекратит работу ");

int sum = 0;
int f = 0;
    while (sum < 100)
    {
    Console.WriteLine("Введите  число пока сумма не привысит 100");
    int num = Convert.ToInt32(Console.ReadLine());

    sum += num;
    f++;
   
    }
    
    Console.WriteLine("Сумма привышает 100 введенно цифр  "+ f );

