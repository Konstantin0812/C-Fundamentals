
int numberOflocation = int.Parse(Console.ReadLine());


for(int i =1; i <= numberOflocation; i++)
{
    double averigedobiv = double.Parse(Console.ReadLine());
    int numberOfdays = int.Parse(Console.ReadLine());
    double totalGold = 0;
    for (int j  = 1; j <= numberOfdays; j++)
    {
        double currentGold = double.Parse(Console.ReadLine());
        totalGold += currentGold;
    }
    double averigeGold = totalGold / numberOfdays;
    
    if(averigeGold >= averigedobiv)
    {
        Console.WriteLine($"Good job! Average gold per day: {averigeGold:f2}.");
    }
    else if(averigeGold < averigedobiv)
    {
        Console.WriteLine($"You need {averigedobiv - averigeGold:f2} gold.");
    }
}
