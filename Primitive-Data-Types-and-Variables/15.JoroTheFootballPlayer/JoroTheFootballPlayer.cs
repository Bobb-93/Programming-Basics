using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leapYear=Console.ReadLine();
        int p=Int32.Parse(Console.ReadLine());
        int h=Int32.Parse(Console.ReadLine());
        int weekends = 52;
        int normalWeekends = weekends - h;
        double numberOfPlays =(p/2)+((2*normalWeekends)/3)+h;

        if (leapYear == "t")
        {
            numberOfPlays = numberOfPlays + 3;
        }
        Console.WriteLine((int)numberOfPlays);
    }
}

