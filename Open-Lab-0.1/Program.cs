using System;

namespace OpenLab
{
    class Program
    {
        public static double Remainder(double number1, double number2) 
        {
            return (number1 % number2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Remainder(1, 3));
        }
    }
}
