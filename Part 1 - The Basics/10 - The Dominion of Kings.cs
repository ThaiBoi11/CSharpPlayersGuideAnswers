int estateCount, duchyCount, provinceCount;
Console.Write("Estate count: ");
estateCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Duchy count: ");
duchyCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Province count: ");
provinceCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total point(s): {0}", estateCount + (3 * duchyCount) + (6 * provinceCount));