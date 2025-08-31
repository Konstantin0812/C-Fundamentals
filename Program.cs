string destination = Console.ReadLine();

while (destination != "End")
{
    double moneyForTrip = double.Parse(Console.ReadLine());

    double savedMoney = 0;
    while (savedMoney < moneyForTrip)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        savedMoney += currentMoney;
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
    
}
