int totalSteps = 0;

string input = Console.ReadLine();
while (input != "Going home")
{
    int steps = int.Parse(input);
    totalSteps += steps;
    if(totalSteps >= 10000)
    {
        break;
    }
  input = Console.ReadLine();
}
if(totalSteps < 10000)
{
    int stepsFromTheParkToHome = int.Parse(Console.ReadLine());
    totalSteps += stepsFromTheParkToHome;
}
if (totalSteps >= 10000)
{
    Console.WriteLine($"Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
}
else
{
    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
}
