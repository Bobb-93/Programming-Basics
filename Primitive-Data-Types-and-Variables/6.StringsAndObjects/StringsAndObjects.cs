using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concatenation = hello +" "+ world;
        string convertedObject=concatenation.ToString();
        Console.WriteLine(convertedObject);
    }
}

