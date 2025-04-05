using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class result
    {
        public string grade;
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            result res1 = new result();
            res1.Grade = "P";
            Console.WriteLine(res1.Grade);
            Console.Read();
        }
    }
}
/*
P
*/
