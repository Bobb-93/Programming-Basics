using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i=0;i<2*n;i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write(' ');
        }
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();

        for(int i=0;i<n-2;i++)
        {
            Console.WriteLine('*');
            for (int j = 0; j < n - 2; i++)
            {
                Console.Write('/');
            }
        }
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write(' ');
        }
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}

