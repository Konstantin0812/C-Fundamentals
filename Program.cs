
int kupenaXrana =( int.Parse(Console.ReadLine()))*1000;

int currentFood = 0;
int totalFood = 0;
int diff = 0;

string input = Console.ReadLine();
while (input != "Adopted")
{
    currentFood = int.Parse(input);
    totalFood += currentFood;


    
    

    input = Console.ReadLine();
}
if (totalFood > kupenaXrana)
{
    Console.WriteLine($"Food is not enough. You need {totalFood - kupenaXrana} grams more.");
    
}
// Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
else if (totalFood <= kupenaXrana)
{
    Console.WriteLine($"Food is enough! Leftovers: {kupenaXrana- totalFood} grams.");
}
