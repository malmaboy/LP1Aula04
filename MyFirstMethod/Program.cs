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
        }
          
        /// <summary>
        /// This method will print numbers from 1 to 10.
        /// </summary>
        static void CountTo10()
        {
            CountTon(10);
        }

        /// <summary>
        /// This methot will print numbers from 1 to <see cref = "n"/>
        /// </summary>
        /// <param name="n"></param>
        static void CountTon(int n)
        {
            for (int i = 1; i <=n;i++)
            {
                Console.WriteLine(i);
            }
        }

       
    }
}
