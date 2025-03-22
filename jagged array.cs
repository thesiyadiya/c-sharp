using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[6];
            arr[2] = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Enter value:");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                 foreach (int[] raw in arr)
                {
                    foreach (int j in raw)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}