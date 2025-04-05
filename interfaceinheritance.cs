using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceinheritance
{
    interface result
    {
        void grade();
    }
    class sem4:result
    {
        public void grade()
        {
            Console.WriteLine("P");
        }
    }
     internal class program
    {
        static  void Main(string[] args)
        {
            sem4 s = new sem4();
            s.grade();
            Console.Read();
        }
    }
}
/*
P
*/

