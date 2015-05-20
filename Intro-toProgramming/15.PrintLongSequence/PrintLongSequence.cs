using System;

class PrintLongSequence
{
    static void Main()
    {
        int n = 2;
        while (n < 1002)
        {
            n++;
            if (n % 2 == 0)
                Console.WriteLine(n);
            else
                Console.WriteLine("-" + n);
        }
    }
}

