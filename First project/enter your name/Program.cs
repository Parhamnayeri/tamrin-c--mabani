using System.Security.Cryptography.X509Certificates;

namespace enter_your_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("PLS ENTER YOUR NAME");
            name = Console.ReadLine();
            Console.WriteLine("WHATSUP\t" + name);
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }
    }
}