//homework3
//void Homework3()

{
    Console.WriteLine("Введіть х");

    var xString = Console.ReadLine();
    Console.WriteLine("Введіть у");

    var yString = Console.ReadLine();
    var canConvertX = int.TryParse(xString, out int x);
    var canConvertY = int.TryParse(yString, out int y);
    if (!canConvertX)
    {
        Console.WriteLine("Помилка введення");
    }
    if (!canConvertY)
    {
        Console.WriteLine("Помилка введення");
    }
    var skoda = 0;
    if (x < y)
    {
        for (int i = x; i <= y; i++)
        {
            skoda = i + skoda;
        }

    }
    else
    {
        for (int i = x; i >= y; i--)
        {
            skoda = i + skoda;

        }

    }
    Console.WriteLine($"отримане значення { skoda}");
}
