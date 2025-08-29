
int requiredHeight = int.Parse(Console.ReadLine());

int failedAttemps = 0;
int totalJumps = 0;
int currentHeight = requiredHeight - 30;

while (true)
{
    int madeJump = int.Parse(Console.ReadLine());
    totalJumps++;

    if(madeJump > currentHeight)
    {
        if(currentHeight >= requiredHeight)
        {
            Console.WriteLine($"Tihomir succeeded, he jumped over {currentHeight}cm after {totalJumps} jumps.");
            break;
        }
        currentHeight += 5;
           failedAttemps = 0;
    }
    else
    {
        failedAttemps++;
        if(failedAttemps == 3)
        {
            Console.WriteLine($"Tihomir failed at {currentHeight}cm after {totalJumps} jumps.");
            break;
        }
    }
}

