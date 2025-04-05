using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operateroverloading
{
    class calculator
    {
        public int number1, number2;
        public calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static calculator operator -(calculator c)
        {
            c.number1 = -c.number1;
            c.number2 = -c.number2;
            return c;
        }
        public void print()
        {
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
    internal class program
    { 
        static void Main(string[] args)
        {
            calculator cal = new calculator(10, -20);
            cal.print();
            cal = - cal;
            cal.print();
            Console.Read();
        }
    }
}

/*output
    10
    -20
    -10
    20
*/