using System;

class QuotesInStrings
{
    static void Main()
    {
        //using quoted string
        string string1 = @"The ""use"" of quotations causes difficulties.";
        //using escaping character
        string string2 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(string1);
        Console.WriteLine(string2);
    }
}

