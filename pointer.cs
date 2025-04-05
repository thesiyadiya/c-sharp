using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            int i = 10;
            int* x = &i;
            Console.WriteLine(i);
            Console.WriteLine((int)x);
            Console.Read();
        }
    }
}
/*
10
123531080
*/