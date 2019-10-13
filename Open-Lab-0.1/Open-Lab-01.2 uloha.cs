using System;

namespace OpenLab
{
    class Program
    {
        public static int Sum(int cislo1, int cislo2)
        {
            return (cislo1 + cislo2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 10));
        }
    }
}
