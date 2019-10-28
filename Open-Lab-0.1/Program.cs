using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Christmas christmas = new Christmas();
            Console.WriteLine(christmas.IsTimeForMilkAndCookies(12, 24));
        }
    }
}
