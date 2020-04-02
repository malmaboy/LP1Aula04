using System;

namespace MyFirstMethod
{
    /// <summary>
    /// this is our project's main class.
    /// </summary>
    class Program
    {

    /// <summary>
    /// This is the main method, the program starts here.
    /// </summary>
    /// <param name="args">Not used in this program.</param>
        static void Main(string[] args)
        {
            CountTon(3);
            CountTon(5);
            CountTo10();
            CountTon(15,19);
        }
          
        /// <summary>
        /// This method will print numbers from 1 to 10.
        /// </summary>
        static void CountTo10()
        {
            CountTon(10);
        }

    /// <summary>
    /// This method will print numbers from 1 to <see cref = "n"/>
    /// </summary>
    /// <param name="n"></param>
        static void CountTon(int n)
        {
            for (int i = 1; i <=n;i++)
            {
                Console.WriteLine(i);
            }
        }


/// <summary>
/// This method will print numbers from <cref ="n1"/n to <cref="n2"/>.
/// </summary>
/// <param name="n1">Minimum number to print</param>
/// <param name="n2">Maximum number to print</param>
        static void CountTon(int n1, int n2)
        {
            for (int i = n1; i <=n2;i++)
            {
                Console.WriteLine(i);
            }

        }

       
    }
}
