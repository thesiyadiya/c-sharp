using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int a = 0; a < arr.Length; a++)
            {
                Console.Write("Enter value:");
                arr[a] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int b in arr)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
