```cs
Console.Title = ("Defense of Consolas");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Target Row? ");
var targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
var targetColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Deploy to:");
Console.WriteLine("({0}, {1}", targetRow, targetColumn - 1);
Console.WriteLine("({0}, {1}", targetRow - 1, targetColumn);
Console.WriteLine("({0}, {1}", targetRow, targetColumn + 1);
Console.WriteLine("({0}, {1}", targetRow + 1, targetColumn);
Console.Beep();
```