Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); //Stores the type of object
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); //Stores an adjective related to the verb
string c = ("Doom"); /* Stores the constant "of doom" */
string d = ("3000"); // Stores the constant "3000"
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
/* The bug is a logical error in lines 5 and 7; both lines have "of" in them, so the  program ends up saying "of of". This has been fixed
 */