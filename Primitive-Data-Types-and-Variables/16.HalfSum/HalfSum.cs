using System;

class HalfSum
    {
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int sum1=0;
        for(int i=0;i<n;i++)
        {
            sum1+=int.Parse(Console.ReadLine());
        }

        int sum2=0;
        for(int i=n;i<2*n;i++)
        {
            sum2+=int.Parse(Console.ReadLine());
        }

        int d=Math.Abs(sum1-sum2);
        if(d==0)
        {
            Console.WriteLine("Yes, sum={0}",sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}",d);
        }

    }
}
