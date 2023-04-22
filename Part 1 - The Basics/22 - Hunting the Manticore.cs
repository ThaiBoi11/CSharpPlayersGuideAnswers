```cs
int manticoreLocation, manticoreHealth = 10, cityHealth = 15, roundCount = 0, cityGuess;
do 
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Player 1, how far away from the city would you like to station the Manticore? ");
    manticoreLocation = Convert.ToInt32(Console.ReadLine());
} while (manticoreLocation > 100 || manticoreLocation < 0); //Player 1 coordinate input
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Player 2, it is your turn. ");
do
{
    Console.ForegroundColor = ConsoleColor.White;
    roundCount++;
    Console.WriteLine("------------------------------------------------------------------------------------");
    Console.WriteLine($"Status: Round {roundCount}  City: {cityHealth}/15   Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to do {BlastDamageCalc()} damage this round.");
    Console.Write("Enter desired cannon range: ");
    cityGuess = 
        Convert.ToInt32(Console.ReadLine());
    if (cityGuess < manticoreLocation)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        cityHealth--;
    }
    if (cityGuess > manticoreLocation)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        cityHealth--;
    }
    if (cityGuess == manticoreLocation)
    {
        Console.WriteLine("That was a DIRECT HIT!");
        manticoreHealth -= BlastDamageCalc();
    }
} while (manticoreHealth > 0 && cityHealth > 0);

if (cityHealth < 0) {
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("The city has fallen. Restart the program to try again");
}
else if (manticoreHealth < 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("The Manticore has fallen. You have won! ");
}
///<summary> 
/// Checks the round number, then returns an integer that represents the amount of damage dealt by that type of round.
/// Hybrid shot = 10 DMG, fire or electric shot = 3 DMG, normal shot = 1 DMG
/// </summary>
int BlastDamageCalc() {
    bool fire = false, electric = false;
    if (roundCount % 3 == 0)
    {
        fire = true;
    }
    if (roundCount % 5 == 0)
    {
        electric = true;
    }
    if (fire && electric) {
        Console.ForegroundColor = ConsoleColor.Blue;
        return (10);    
    }
    else if (fire || electric) {
        if (fire && !electric) {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (electric && !fire) {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        return (3); ;
    }
    else {
        return (1);
    }
}
```