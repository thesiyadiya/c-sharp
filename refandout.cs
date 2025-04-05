using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refout
{
    class refout
    {
        public int outparameter(out int a, out int b)
        {
            a = 20;
            b = 20;
            return a + b;
        }
        public int refparameter(ref int a, ref int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            refout ro = new refout();
            Console.Write(ro.outparameter(out i, out j));
            Console.Write(ro.refparameter(ref i, ref j));
            Console.Read();
        }
    }
}
/*
4040
*/
