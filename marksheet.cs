using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m1, m2, total;
            double per;
            string grade, result;
            Console.WriteLine("Enter marks 1:");
            m1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks 2:");
            m2=Convert.ToInt32(Console.ReadLine());
            total = m1 + m2;
            if(m1>=40 && m2>=40)
            {
                result = "PASS";
                per = Convert.ToDouble(total) / 2;
                if (per >= 70)
                {
                    grade = "A";
                }
                else if(per>=60)
                {
                    grade = "B";
                }
                else if(per>=50)
                {
                    grade = "C";
                }
                else
                {
                    grade="D";
                }
            }
            else
            {
                result = "FAIL";
                per = 0;
                grade = "F";
            }
            Console.WriteLine("Toatal:" + total);
            Console.WriteLine("Percentage:" + per);
            Console.WriteLine("Result:"+result);
            Console.WriteLine("Grade:"+grade);
            Console.Read();
        }
    }
}
