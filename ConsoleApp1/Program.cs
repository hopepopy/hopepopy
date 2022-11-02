namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Birthday();
            int positionX = 1;
            int positionY = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {

                if (key.Key == ConsoleKey.UpArrow)
                {
                    positionX--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    positionX++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    positionY--;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    positionY++;
                }
                if (positionY == 1)
                {
                    Birthday();
                    Strelki(positionX);
                    key = Console.ReadKey();
                }
                else if (positionY == 2)
                {
                    AnotherDay();
                    Strelki(positionX);
                    key = Console.ReadKey();
                }
                else if (positionY == 3)
                {
                    Weekend();
                    Strelki(positionX);
                    key = Console.ReadKey();
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (positionX == 2 & positionY == 1)
                    {
                        Crying();
                        Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }
                    else if (positionX == 1 & positionY == 1)
                    {
                        Birth();
                        Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }
                    else if (positionX == 1 & positionY == 2)
                    {
                        DoomerMood();
                        Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }
                    else if (positionX == 2 & positionY == 2)
                    {
                        DSBM();
                        Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }
                    else if (positionX == 1 & positionY == 3)
                    {
                        Friends();
                        Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }

                }
            }
            static void Birthday()
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата 07.02.2006.");
                Console.WriteLine("  1. Родиться.");
                Console.WriteLine("  2. Плакать и кричать.");

            }
            static void Birth()
            {
                Console.Clear();
                Console.WriteLine("1. Родиться.");
                Console.WriteLine("Все существа перед началом существования рождаются. Такая же обязательная штука как смерть.");
                Console.WriteLine("Время: примерно в 9 часов вечера.");
            }
            static void Crying()
            {
                Console.Clear();
                Console.WriteLine("2. Плакать и кричать.");
                Console.WriteLine("Это делают большинство живых новорожденных детей.");
                Console.WriteLine("Время: после рождения. Примерно в 9 часов вечера.");
            }
            static void AnotherDay()

            {
                Console.Clear();
                Console.WriteLine("Выбрана дата 25.09.2022.");
                Console.WriteLine("  1. Плакать и вспоминать те светлые дни.");
                Console.WriteLine("  2. Написать вступление к песне.");

            }
            static void DoomerMood()
            {
                Console.Clear();
                Console.WriteLine("1. Плакать и вспоминать те светлые дни.");
                Console.WriteLine("Это будет просто. За 2 года мы научились делать это профессионально.");
                Console.WriteLine("Время: по пути домой, в метро.");
            }
            static void DSBM()
            {
                Console.Clear();
                Console.WriteLine("2. Написать вступление к песне.");
                Console.WriteLine("Не зря же мы учились в музыкалке 7 лет.");
                Console.WriteLine("Время: после выполнения первой заметки.");
            }
            static void Weekend()
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата 06.11.2022");
                Console.WriteLine("  1. Сходить с друзьями в заброшку и лес.");
            }
            static void Friends()
            {
                Console.Clear();
                Console.WriteLine("1. Сходить с друзьями в заброшку и лес.");
                Console.WriteLine("У нас появились классные друзья. Нужно поддерживать с ними связь.");
                Console.WriteLine("Время: утром, в 10 часов.");
            }
            static void Strelki(int positionX)
            {
                Console.SetCursorPosition(0, positionX);
                Console.WriteLine("->");
            }
        }
    }
}

