using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a=null;
        double? b=null;

        Console.WriteLine(a);
        Console.WriteLine(b);

        a += 7;
        b += 3.5;
        Console.WriteLine(a);
        Console.WriteLine(b);

        /*In this way we can actually asign values
        a = 7;
        b = 3.5;
        Console.WriteLine(a);
        Console.WriteLine(b);
         */
    }
}

