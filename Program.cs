int[] ChangeOctave(int kontainer)
{
    int[] firstOct = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
    int[] secondOct = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
    int[] thirdOct = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
    int[] fourthOct = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    int[] idk = new int[] {};
    if (kontainer == 1)
    {
        return firstOct;
    }
    else if (kontainer == 2)
    {
        return secondOct;
    }
    else if (kontainer == 3)
    {
        return thirdOct;
    }
    else if (kontainer == 4)
    {
        return fourthOct;
    }
    else
    {
        return idk;
    }
}
int Oct(int[] octave, int konteiner)
{
    if (konteiner == 0)
    {
        return octave[0];
    }
    else if (konteiner == 1)
    {
        return octave[1];
    }
    else if (konteiner == 2)
    {
        return octave[2];
    }
    else if (konteiner == 3)
    {
        return octave[3];
    }
    else if (konteiner == 4)
    {
        return octave[4];
    }
    else if (konteiner == 5)
    {
        return octave[5];
    }
    else if (konteiner == 6)
    {
        return octave[6];
    }
    else if (konteiner == 7)
    {
        return octave[7];
    }
    else if (konteiner == 8)
    {
        return octave[8];
    }
    else if (konteiner == 9)
    {
        return octave[9];
    }
    else if (konteiner == 10)
    {
        return octave[10];
    }
    else if (konteiner == 11)
    {
        return octave[11];
    }
    else
    {
        return octave[12];
    }
}
ConsoleKeyInfo n;
Console.WriteLine("Переключение октав на клавиши 1, 2, 3 и 4");
int[] selectedOctave = ChangeOctave(1);
Console.WriteLine("Первая октава");
do
{
    n = Console.ReadKey();
    Console.Clear();
    if (n.Key == ConsoleKey.B)
    {
        Console.Beep(587, 400);
        Console.Beep(349, 400);
        Console.Beep(466, 400);
        Console.Beep(587, 400);
        Console.Beep(784, 800);
        Console.Beep(698, 800);
        Console.Beep(587, 400);
        Console.Beep(349, 400);
        Console.Beep(466, 400);
        Console.Beep(587, 400);
        Console.Beep(784, 800);
        Console.Beep(698, 800);
        Console.Beep(587, 300);
        Console.Beep(587, 1500);
        Console.Beep(466, 300);
        Console.Beep(523, 300);
        Console.Beep(587, 300);
        Console.Beep(587, 1500);
        Console.Beep(587, 300);
        Console.Beep(587, 300);
        Console.Beep(622, 500);
        Console.Beep(698, 800);
        Console.Beep(622, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 1000);
        Console.Beep(523, 400);
        Console.Beep(587, 300);
        Console.Beep(622, 500);
        Console.Beep(698, 800);
        Console.Beep(622, 500);
        Console.Beep(587, 500);
        Console.Beep(523, 1000);
    }
    if (n.Key == ConsoleKey.M)
    {
        Console.Beep(587, 300);
        Console.Beep(587, 300);
        Console.Beep(1175, 400);
        Console.Beep(880, 700);
        Console.Beep(830, 300);
        Console.Beep(784, 300);
        Console.Beep(698, 300);
        Console.Beep(587, 200);
        Console.Beep(659, 200);
        Console.Beep(698, 200);
    }

    switch (n.Key)
    {
        case ConsoleKey.D1:
            selectedOctave = ChangeOctave(1);
            Console.WriteLine("Первая октава");
            break;
        case ConsoleKey.D2:
            selectedOctave = ChangeOctave(2);
            Console.WriteLine("Вторая октава");
            break;
        case ConsoleKey.D3:
            selectedOctave = ChangeOctave(3);
            Console.WriteLine("Третья октава");
            break;
        case ConsoleKey.D4:
            selectedOctave = ChangeOctave(4);
            Console.WriteLine("Четвертая октава");
            break;
        case ConsoleKey.A:
            Console.Beep(Oct(selectedOctave, 0), 700);
            Console.Clear();
            break;
        case ConsoleKey.W:
            Console.Beep(Oct(selectedOctave, 1), 700);
            Console.Clear();
            break;
        case ConsoleKey.S:
            Console.Beep(Oct(selectedOctave, 2), 700);
            Console.Clear();
            break;
        case ConsoleKey.E:
            Console.Beep(Oct(selectedOctave, 3), 700);
            Console.Clear();
            break;
        case ConsoleKey.D:
            Console.Beep(Oct(selectedOctave, 4), 700);
            Console.Clear();
            break;
        case ConsoleKey.F:
            Console.Beep(Oct(selectedOctave, 5), 700);
            Console.Clear();
            break;
        case ConsoleKey.T:
            Console.Beep(Oct(selectedOctave, 6), 700);
            Console.Clear();
            break;
        case ConsoleKey.G:
            Console.Beep(Oct(selectedOctave, 7), 700);
            Console.Clear();
            break;
        case ConsoleKey.Y:
            Console.Beep(Oct(selectedOctave, 8), 700);
            Console.Clear();
            break;
        case ConsoleKey.H:
            Console.Beep(Oct(selectedOctave, 9), 700);
            Console.Clear();
            break;
        case ConsoleKey.U:
            Console.Beep(Oct(selectedOctave, 10), 700);
            Console.Clear();
            break;
        case ConsoleKey.J:
            Console.Beep(Oct(selectedOctave, 11), 700);
            Console.Clear();
            break;
    }
} while (n.Key != ConsoleKey.Escape);
