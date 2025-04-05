using System;

namespace @event
{
    class Program
    {
        public delegate void EventHandler(string a);

        public class Operation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        public static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }

        static void Main(string[] args)
        {
            Operation o = new Operation();
            o.xyz += new EventHandler(CatchEvent);
            o.Action("Event Calling");
            Console.ReadLine();
        }
    }
}
/*
Method Calling
Event Calling
*/

