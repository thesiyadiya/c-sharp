using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedandabstrct
{
    sealed class class1
    {
        public void print()
        {
            Console.WriteLine("Sealedclass");
        }
    }
    abstract class class2
    {
        public abstract void print();
    }
    class class3 : class2
    {
        public override void print()
        {
            Console.WriteLine("Abstractclass");
        }
    }
    internal class program
    { 
        static void Main (string[] args)
        {
            class1 c1 = new class1();
            c1.print();
            class3 c3 = new class3();
            c3.print();
            Console.Read();
        }
    }
}
/*
Sealedclass
Abstractclass
*/