```cs
int[] array1 = new int[5];
int[] array2 = new int[5];
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"What should go in index {i+1}?: ");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}
Console.WriteLine("The contents of array 1 are:");
foreach (var item in array1)
{
    Console.WriteLine(item);
}
Console.WriteLine("whereas the contents of array 2 are:");
foreach (var item in array2)
{
    Console.WriteLine(item);
}
```