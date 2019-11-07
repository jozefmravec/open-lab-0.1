using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        public void Array()
        {
            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(array[1, 2]);
        }
    }
}
