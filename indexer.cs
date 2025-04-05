using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class result
    {
        public string[] grade = new string[5];
        public string this[int i]
        {
            get { return grade[i]; }
            set { grade[i] = value; }
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            result res1 = new result();
            res1[0] = "A";
            res1[1] = "B";
            res1[2] = "C";
            res1[3] = "D";
            res1[4] = "F";
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(res1[i]);
            }
            Console.Read();
        }
    }
}
/*
A
B
C
D
F
*/
