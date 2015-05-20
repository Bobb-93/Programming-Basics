using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthDate;
        Console.WriteLine("Enter Birthdate, please:");
        birthDate = DateTime.Parse(Console.ReadLine());

        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        Console.WriteLine(age);
        age += 10;
        Console.WriteLine("After 10 Years I will be: " + age + " years old");
    }
}

