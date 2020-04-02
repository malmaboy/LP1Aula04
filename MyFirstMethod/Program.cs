using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTon(3);
            CountTon(5);
            CountTo10();
        }
          

        static void CountTo10()
        {
            CountTon(10);
        }

        static void CountTon(int n)
        {
            for (int i = 1; i <=n;i++)
            {
                Console.WriteLine(i);
            }
        }

       
    }
}
