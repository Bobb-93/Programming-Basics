﻿using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        int c=a;
        a = b;
        b = c;
        Console.WriteLine("After:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

