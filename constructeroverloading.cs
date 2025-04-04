using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructeroverloading
{
    class constructer
    {
        public constructer(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public constructer(string result, string grade)
        {
            Console.WriteLine(result + "," + grade);
        }
        internal class program
        {
            static void Main(string[] args)
            {
                constructer a = new constructer(10, 20);
                constructer a1 = new constructer("FAIL", "F");
                Console.Read();
            }
        }
    }
}
