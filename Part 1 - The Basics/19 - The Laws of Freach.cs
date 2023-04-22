```cs
//Smallest value in an array
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int i in array)
{
    if (i < currentSmallest)
        currentSmallest = array[i];
}
Console.WriteLine(currentSmallest);

// Average of an array
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;

foreach (int i in array)
{
    total = total + i;
}
Console.WriteLine(total/array.Length);
```