using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, , ,] arr = new int[3, 3, 3, 3];
            for (int a = 0; a < 3; a++)
      
                {
                    for (int b = 0; b < 3; b++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            for (int d = 0; d < 3; d++)
                            {
                                Console.Write("Enter Value:");
                                arr[a, b, c, d] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }
                }
                foreach(int b in arr)
                {
                    Console.WriteLine(b);
                }
            Console.Read();
            }
        }
    }
