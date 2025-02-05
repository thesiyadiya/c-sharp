using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            int ii = 1;
            while (ii <= 5)
            {

                int j = 1;
                while (j <= ii)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                ii++;
            }
            int iii = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.Write(j);
                    j++;
                } while (j <= iii);
                iii++;
                Console.WriteLine();
            } while (iii <= 5);
            Console.Read();
        }
    }
}
