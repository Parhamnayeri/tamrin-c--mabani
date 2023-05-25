namespace mult3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a number to get mult*3");
            string number = Console.ReadLine();
            a = int.Parse(number);
            a = 3 * a;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}