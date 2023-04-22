int chocolateEggs;
Console.Write("Enter the number of eggs: ");
chocolateEggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sisters get {0} egg(s) each and the duckbear gets {1} egg(s).", chocolateEggs / 4, chocolateEggs % 4);