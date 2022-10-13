using System.Runtime.CompilerServices;

static void Guesser()
{
    Random rand = new Random();
    int x = rand.Next(0, 100); ;
    int y;
    Console.WriteLine("Случайное число от 1 до 100 загадано.");
    do
    {
        Console.WriteLine("Ваше предположение: ");
        y = Convert.ToInt32(Console.ReadLine());
        if (y == x)
        {
            Console.WriteLine("ВЫ УГАДАЛИ УРААА");
        }
        if (y > x)
        {
            Console.WriteLine("Слишком большое");
        }
        if (y < x)
        {
            Console.WriteLine("Слишком маленькое");
        }
    } while (y != x);
}
static void Tablitsa()
{
    int[,] tablitsa = new int[10, 10];
    int x;
    int y = 0;
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        tablitsa[x, 0] = x;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 1;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 2;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 3;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 4;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 5;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 6;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 7;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 8;
        tablitsa[x, y] = x * y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        y = 9;
        tablitsa[x, y] = x * y;
    }
    for (y = 0; y < tablitsa.GetLength(0); y++)
    {
        tablitsa[0, y] = y;
    }
    for (x = 0; x < tablitsa.GetLength(0); x++)
    {
        for (y = 0; y < tablitsa.GetLength(1); y++)
        {
            Console.Write(tablitsa[x, y] + "\t");
        }
        Console.WriteLine();
    }
}
static void Deliteli()
{
    string a;
    do
    {

        Console.WriteLine("Введите число. Что бы выйти введите 'выход'");
        a = Console.ReadLine();
        switch (a)
        {
            case "выход":
                break;
            default:
                int x = Convert.ToInt32(a);
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
        }
    } while (a != "выход");
}
int m;
do
{

    Console.WriteLine("Выберете программу: \n1 - Игра 'Угадай число' \n2 - Таблица умножения \n3 - Вывод делителей числа \n4 - Выход");
    m = Convert.ToInt32(Console.ReadLine());
    switch (m)
    {
        case 1:
            Guesser();
            break;
        case 2:
            Tablitsa();
            break;
        case 3:
            Deliteli();
            break;
    }
} while (m != 4);
