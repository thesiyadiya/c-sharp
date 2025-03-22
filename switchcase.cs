using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            switch (i)
            {
                case 1:
                    Console.WriteLine("Pass");
                    break;
                case 10:
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.Read();
        }
    }
}
