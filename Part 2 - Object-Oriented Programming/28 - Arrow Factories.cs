ArrowheadType userArrowhead = ArrowheadType.steel;
FletchingType userFletching = FletchingType.plastic;
int userLength, userChoice;
Console.WriteLine("Would you like a custom arrow? Type \"Yes\" if so");
string customAnswer = Console.ReadLine();
if (customAnswer == "Yes")
{
    Console.WriteLine("What arrowhead would you like? \n1. Steel \n2. Wood \n3. Obsidian");
    userChoice = Convert.ToInt32(Console.ReadLine());
    while (userChoice > 3 || userChoice < 1)
    {
        switch (userChoice)
        {
            case 1:
                userArrowhead = ArrowheadType.steel;
                break;
            case 2:
                userArrowhead = ArrowheadType.wood;
                break;
            case 3:
                userArrowhead = ArrowheadType.steel;
                break;
            default:
                Console.WriteLine("Sorry, you have not picked a valid choice. Please try again. ");
                userChoice = Convert.ToInt32(Console.ReadLine());
                break;
        }
    }
    userChoice = 0;
    Console.WriteLine("What fletching would you like? \n1. Plastic \n2. Turkey Feathers \n3. Goose feathers");
    userChoice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How long would you like your arrow to be? ");
    userChoice = Convert.ToInt32(Console.ReadLine());
    while (userChoice < 60 || userChoice > 100)
    {
        Console.WriteLine("Sorry, your arrow is either too short or too long. Make sure your arrow is between 60 and 100 cm. How long would you like your arrow to be? \n");
        userChoice = Convert.ToInt32(Console.ReadLine());
    }
    userLength = userChoice;
    userChoice = 0;
    Arrow CustomArrow = new Arrow(userArrowhead, userFletching, userLength);
    Console.WriteLine($"Your arrow will cost{CustomArrow.GetCost}");
}
else
{
    int presetChoice = -1;
    Arrow presetArrow = new Arrow(ArrowheadType.steel, FletchingType.plastic, 100);
    Console.WriteLine("Select an preset arrow. \n1. The Elite Arrow \n2. The Beginner Arrow \n3. The Marksman Arrow.");
    while (presetChoice < 1 || presetChoice > 3)
    {
        presetChoice = int.Parse(Console.ReadLine());
        switch (presetChoice)
        {
            case 1:
                presetArrow = Arrow.CreateEliteArrow();
                break;
            case 2:
                presetArrow = Arrow.CreateBeginnerArrow();
                break;
            case 3:
                presetArrow = Arrow.CreateMarksmanArrow();
                break;
            default:
                Console.WriteLine("Apologies, you have not input a valid choice. Please try again.");
                break;
        }
    }
    Console.WriteLine($"Your arrow will cost {presetArrow.GetCost(presetArrow)}");
}
class Arrow
{
    private ArrowheadType _arrowhead;
    private FletchingType _fletching;
    private int _shaft;
    public Arrow(ArrowheadType arrowhead, FletchingType fletching, int shaft)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _shaft = shaft;
    }
    public float GetCost(Arrow arrow)
    {
        float cost = 0;
        switch (arrow._arrowhead)
        {
            case ArrowheadType.steel:
                cost += 10;
                break;
            case ArrowheadType.wood:
                cost += 3;
                break;
            case ArrowheadType.obsidian:
                cost += 5;
                break;
            default:
                break;
        }
        switch (arrow._fletching)
        {
            case FletchingType.plastic:
                cost += 10;
                break;
            case FletchingType.turkeyfeathers:
                cost += 5;
                break;
            case FletchingType.goosefeathers:
                cost += 3;
                break;
            default:
                break;
        }
        return cost + ((float)(arrow._shaft * 0.05));

    }

    public int Shaft { get; set; }
    public ArrowheadType Arrowhead { get; set; }
    public FletchingType Fletching { get; set; }
    public static Arrow CreateEliteArrow()
    {
        return new Arrow(ArrowheadType.steel, FletchingType.plastic, 95);
    }
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(ArrowheadType.wood, FletchingType.goosefeathers, 75);
    }
    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(ArrowheadType.steel, FletchingType.goosefeathers, 65);
    }
}
enum ArrowheadType
{
    steel, wood, obsidian
}
enum FletchingType
{
    plastic, turkeyfeathers, goosefeathers
}