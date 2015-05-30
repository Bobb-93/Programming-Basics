using System;
using System.Globalization;
using System.Threading;
class ComparingFloats
{
    static void Main()
    {

        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double difference = Math.Abs(a - b);
        const double eps = 0.01;
        bool equal = false;
	    
        if (difference == eps || difference > eps)
        {
            equal = false;
        }
        else if (difference < eps)
        {
            equal = true;
        }

        Console.WriteLine(equal);
        Console.WriteLine(eps);
    }
}

