using System;

namespace Open_Lab
{
    class Program
    {
        public static int TriArea(int strana, int vyska)
        {
            return (strana * vyska) / 2;                
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TriArea(12, 8));
        }
    }
}
