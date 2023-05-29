using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace fib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tachand ozve fib ro barat benevisam ?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ozve 1 ta " + n+ "  ebaart ast az :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fib(i)+" ");
            }

        }
        static int fib(int n)
        {
            if (n <= 1)
              return n;
            else
                return fib(n - 1) + fib(n - 2);
        }
    }
}