namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();// Стрингът който трябва да премахнем 
            string fullString = Console.ReadLine();// Целият стринг от който трябва да се премахнат определени думи 

            while(fullString.Contains(substringToRemove))//  Цикълът ще върви, докато fullString съдържа думата "ice". //Примерно 
            {
                int startIndex = fullString.IndexOf(substringToRemove);// Намираш позицията, където за първи път се появява "ice" в fullString.В "kicegiciceeb" → първото "ice" започва на позиция 1 (индексите започват от 0).

                fullString =  fullString.Remove(startIndex, substringToRemove.Length);// Изтрий от fullString, започвайки от startIndex, толкова символа, колкото е дълъг поднизът.“"ice" е 3 символа → махаме 3 символа, започвайки от позиция 1 → "kicegiciceeb" → става "kgiciceeb"
            }

            Console.WriteLine(fullString);
        }
    }
}
