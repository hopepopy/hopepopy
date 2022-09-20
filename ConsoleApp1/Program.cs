using System;

Console.WriteLine("Выберете номер действия:");
Console.WriteLine("1. Сложить два числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
int a = 0;
int c = 1;
int i = 1;
while (a < 10)
{
    a = Convert.ToInt32(Console.ReadLine());

        if (a == 1)
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        c = x + y;
        Console.WriteLine("Сумма равна: " + c);
        Console.WriteLine("Введите номер действия");
    }
        if (a == 2)
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        c = x - y;
        Console.WriteLine("Разница равна: " + c);
        Console.WriteLine("Введите номер действия");
    }
        if (a == 3)
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        c = x * y;
        Console.WriteLine("Умножение равно: " + c);
        Console.WriteLine("Введите номер действия");
    }
        if (a == 4)
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        c = x / y;
        Console.WriteLine("Деление равно: " + c);
        Console.WriteLine("Введите номер действия");
    }
        if (a == 5)
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        int s = 1;
        for(i = 1; i <= y; i++)
    {
            s = s * x;
    }
        Console.WriteLine("Степень равна: " + s);
        Console.WriteLine("Введите номер действия");
    }
        if (a == 6)
    {
        Console.WriteLine("Введите число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Квадратный корень числа равен: " + Math.Sqrt(x));
        Console.WriteLine("Введите номер действия");
    }
        if (a == 7)
    {
        Console.WriteLine("Введите число:");
        int x = Convert.ToInt32(Console.ReadLine());
        c = x / 100;
        Console.WriteLine("1 процент равен: " + c);
        Console.WriteLine("Введите номер действия");
    }
        if (a == 8)
    { 
        Console.WriteLine("Введите число:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == 0)
        {
            Console.WriteLine("Ошибка");
            Console.WriteLine("Введите номер действия");
        }
        else
        {
            while (i != x)
            {
                i++;
                c *= i;
            }

            Console.WriteLine("Факториал равен: " + c);
            Console.WriteLine("Введите номер действия");
        }

    }
        if (a == 9)
    {
        Environment.Exit(0);
    }


}
Console.WriteLine("Ошибка"); 