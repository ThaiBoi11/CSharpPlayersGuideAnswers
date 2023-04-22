```cs
int pilotNumber, hunterGuess = -1;
do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
} while (pilotNumber < 0 || pilotNumber > 100);
Console.Clear();
Console.WriteLine("User 2, guess the number");
while (hunterGuess != pilotNumber)
{
    Console.WriteLine("What is your next guess?");
    hunterGuess = Convert.ToInt32(Console.ReadLine());
    if (hunterGuess < pilotNumber)
    {
        Console.WriteLine("{0} is too low", hunterGuess);

    }
    else if (hunterGuess > pilotNumber)
    {
        Console.WriteLine("{0} is too high", hunterGuess);
    }
    
}
Console.WriteLine("You guessed the number!");
```