int answer;
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