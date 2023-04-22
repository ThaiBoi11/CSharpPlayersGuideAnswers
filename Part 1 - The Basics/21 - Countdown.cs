void WriteNumberUntil0(int number)
{
    if (number != 0) {
        Console.WriteLine(number);
        WriteNumberUntil0(number - 1);
    }
}

WriteNumberUntil0(10);