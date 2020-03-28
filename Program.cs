using System;

namespace project7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,S=0;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            for(int i=a;i<=b;i++)
            {
                S=S+i;
            }
            Console.WriteLine(S);
            
        }
    }
}
