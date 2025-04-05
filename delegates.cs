using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            addnum del1 = new addnum(obj.sum);
            subnum del2 = new subnum(obj.sub);
            del1(10, 5);
            del2(10, 5);
            Console.Read();
        }
    }
}
/*
15
5
*/
