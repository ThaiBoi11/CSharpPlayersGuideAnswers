Console.WriteLine("What is the base of the triangle? ");
int baseTriangle = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the height of the triangle? ");
int heightTriangle = Convert.ToInt32(Console.ReadLine());
float areaTriangle = Convert.ToSingle(baseTriangle * heightTriangle * 0.5);
Console.WriteLine("The area of this triangle is {0}", areaTriangle);