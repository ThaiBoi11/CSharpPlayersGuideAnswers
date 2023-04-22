```cs
int answer, cost;
string name;
Console.WriteLine("The following items are available");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
answer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What's your name?");
name = Console.ReadLine();
switch (answer)
{
	case 1:
		cost = 10;
		if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("Rope costs {0} gold", cost);
		break;
	case 2:
		cost = 15;
		if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("Torches cost {0} gold", cost);
		break;
	case 3:
		cost = 25;
		if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("Climbing equipment costs {0} gold", cost);
		break;
	case 4:
		cost = 1;
		if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("Clean water costs {0} gold", cost);
		break;
	case 5:
		cost = 20;
		if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("A machete costs {0} gold", cost);
		break;
	case 6:
		cost = 200;
        if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("A canoe costs {0} gold", cost);
		break;
	case 7:
		cost = 1;
        if (name == "Raghav")
        {
            cost = cost / 2;
        }
        Console.WriteLine("Food supplies cost {0} gold", cost);
		break;
	default:
		Console.WriteLine("Apologies. We don't have that in stock right now.");
		break;
}
```