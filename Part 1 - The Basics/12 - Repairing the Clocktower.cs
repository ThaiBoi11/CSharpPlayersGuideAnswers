int tickTock;
Console.Write("Number of ticks: ");
tickTock = Convert.ToInt32(Console.ReadLine());
if (tickTock % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}