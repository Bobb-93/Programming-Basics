using System;

class PrintTheASCIITable
{
    static void Main()
    {

        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            switch (symbol)
            {
                case '\t':
                    Console.WriteLine("\\t");
                    break;
                case ' ':
                    Console.WriteLine("space");
                    break;
                case '\n':
                    Console.WriteLine("\\n");
                    break;
                case '\r':
                    Console.WriteLine("\\r");
                    break;
                case '\v':
                    Console.WriteLine("\\v");
                    break;
                case '\f':
                    Console.WriteLine("\\f");
                    break;
            }
            Console.WriteLine(i+": " + symbol);
        }
    }
}

