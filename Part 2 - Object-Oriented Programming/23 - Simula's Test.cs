ChestStatus lockStatus = ChestStatus.Locked;
string lockRequest;
do {
    Console.Write($"The chest is {lockStatus}. What do you want to do? "
        );
    lockRequest = Console.ReadLine();

    switch (lockRequest)
    {
        case ("unlock"):
            if (lockStatus == ChestStatus.Locked)
            {
                lockStatus = ChestStatus.Unlocked;
            }
            break;
        case ("lock"):
            if (lockStatus == ChestStatus.Unlocked)
            {
                lockStatus = ChestStatus.Locked;
            }
            if (lockStatus == ChestStatus.Closed)
            {
                lockStatus = ChestStatus.Locked;
            }
            break;
        case ("open"):
            if (lockStatus == ChestStatus.Closed)
            {
                lockStatus = ChestStatus.Open;
            }
            if (lockStatus == ChestStatus.Unlocked)
            {
                lockStatus = ChestStatus.Open;
            }
            break;
        case ("close"):
            if (lockStatus == ChestStatus.Open)
            {
                lockStatus = ChestStatus.Closed;
            }

            break;
        default:
            break;
    }
} while (true);
enum ChestStatus
{
    Locked, Unlocked, Closed, Open
}