int n = int.Parse(Console.ReadLine());
int presentationsCount = 0;
double totalSumOfGrades = 0;
string command;
while ((command = Console.ReadLine()) != "Finish")
{
    string presentationName = command;
    presentationsCount++;
    double sumOfGrade = 0;
    for(int i = 0; i < n; i++)
    { 
        double grade = double.Parse(Console.ReadLine());
        sumOfGrade += grade;
        totalSumOfGrades += grade;
    }
    Console.WriteLine($"{presentationName} - {sumOfGrade / n:f2}. ");

}
Console.WriteLine($"Student's final assessment is {totalSumOfGrades / (presentationsCount * n):f2}. ");