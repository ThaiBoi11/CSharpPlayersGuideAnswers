```cs
// The Four Sisters and The Duckbear w/ AskForNumber
int chocolateEggs = AskForNumber("Enter the number of eggs: ");
Console.WriteLine("The sisters get {0} egg(s) each and the duckbear gets {1} egg(s).", chocolateEggs / 4, chocolateEggs % 4);


int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Buying Inventory w/ AskForNumberInRange

int answer;
Console.WriteLine("The following items are available");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
answer = AskForNumberInRange("What item would you like to see the price of?: ", 1, 7)
switch (answer)
{
	case 1:
		Console.WriteLine("Rope costs 10 gold");
		break;
	case 2:
		Console.WriteLine("Torches cost 15 gold");
		break;
	case 3:
		Console.WriteLine("Climbing equipment costs 25 gold");
		break;
	case 4:
		Console.WriteLine("Clean water costs 1 gold");
		break;
	case 5:
		Console.WriteLine("A machete costs 20 gold");
		break;
	case 6:
		Console.WriteLine("A canoe costs 200 gold");
		break;
	case 7:
		Console.WriteLine("Food supplies cost 1 gold");
		break;
	default:
		Console.WriteLine("Apologies. We don't have that in stock right now.");
		break;
}

int AskForNumberInRange (string text, int min, int max)
{
    int returnValue;
    do
    {
        Console.Write(text);
        returnValue = Convert.ToInt32(Console.ReadLine());
    }
    while (returnValue > max || returnValue < min);
    return returnValue;
}
```