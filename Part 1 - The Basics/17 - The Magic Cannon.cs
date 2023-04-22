
```cs
bool fire = false, electric = false;
for (int i = 0; i < 101; i++)
{
    if (i % 3 == 0) {
        fire = true;
    }
    if (i % 5 == 0) {
        electric = true;
    }
    if (fire && electric)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("{0}: Fire and Electric", i);
        fire = false;
        electric = false;
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (fire && !electric)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0}: Fire", i);
        fire = false;
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (!fire && electric)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0}: Electric", i);
        electric = false;
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.WriteLine("{0}: Normal", i);
    }
}
```