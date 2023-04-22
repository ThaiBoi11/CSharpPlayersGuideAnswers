```cs
(SoupType, SoupMain, SoupSeasoning) food = (SoupType.soup, SoupMain.potatoes, SoupSeasoning.salty); // "Default" values because apparently computers don't realise when they're in an infinite loop

Console.WriteLine("What kind of food do you want?");
Console.WriteLine("1. Soup");
Console.WriteLine("2. Stew");
Console.WriteLine("3. Gumbo");
Console.WriteLine("Enter your choice as a number: ");
int typeChoice = Convert.ToInt32(Console.ReadLine());
while (typeChoice < 1 || typeChoice > 3)
{
    switch (typeChoice)
    {
        case 1:
            food.Item1 = SoupType.soup;
            break;
        case 2:
            food.Item1 = SoupType.stew;
            break;
        case 3:
            food.Item1 = SoupType.gumbo;
            break;
        default:
            Console.WriteLine("Sorry, you have not entered a valid choice. Please try again. ");
            typeChoice = Convert.ToInt32(Console.ReadLine());
            break;
    }
}
Console.WriteLine("Great! Now, what main ingredient would you like?");
Console.WriteLine("1. Mushrooms");
Console.WriteLine("2. Chicken");
Console.WriteLine("3. Carrots");
Console.WriteLine("4. Potatoes");
Console.WriteLine("Enter your choice as a number: ");
int mainChoice = Convert.ToInt32(Console.ReadLine());
while (typeChoice < 0 || typeChoice > 4)
{
    switch (mainChoice)
    {
        case 1:
            food.Item2 = SoupMain.mushrooms;
            break;
        case 2:
            food.Item2 = SoupMain.chicken;
            break;
        case 3:
            food.Item2 = SoupMain.carrots;
            break;
        case 4:
            food.Item2 = SoupMain.potatoes;
            break;
        default:
            Console.WriteLine("Sorry, you have not entered a valid choice. Please try again. ");
            mainChoice = Convert.ToInt32(Console.ReadLine());
            break;
    }
}
Console.WriteLine("Finally, what type of seasoning would you like?");
Console.WriteLine("1. Spicy");
Console.WriteLine("2. Salty");
Console.WriteLine("3. Sweet");
Console.WriteLine("Enter your choice as a number: ");
int seasonChoice = Convert.ToInt32(Console.ReadLine());
while (seasonChoice < 0 || seasonChoice > 3)
{
    switch (seasonChoice)
    {
        case 1:
            food.Item3 = SoupSeasoning.spicy;
            break;
        case 2:
            food.Item3 = SoupSeasoning.salty;
            break;
        case 3:
            food.Item3 = SoupSeasoning.sweet;
            break;
        default:
            Console.WriteLine("Sorry, that is not a valid option. Please try again.");
            seasonChoice = Convert.ToInt32(Console.ReadLine());
            break;
    }
}
Console.WriteLine($"You have ordered a {food.Item3} {food.Item1} with {food.Item2}");
enum SoupType
{
    soup, stew, gumbo
}
enum SoupMain
{
    mushrooms, chicken, carrots, potatoes
}
enum SoupSeasoning
{
    spicy, salty, sweet
}
```