```cs
int x, y;
Console.Write("X position: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y position: ");
y = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    }
    else if (y == 0)
    {
        Console.WriteLine("The enemy is to the west!");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is to the southwest!");
    }
}
else if (x == 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the north!");
    }
    else if (y == 0)
    {
        Console.WriteLine("The enemy is here!");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is to the south!");
    }
}
else if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northeast!");
    }
    else if (y == 0)
    {
        Console.WriteLine("The enemy is to the east!");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
}
```