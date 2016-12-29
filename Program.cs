using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Demo
    {
        public static string x = "Static variable";
        public static void show()
        {
            Console.WriteLine("Static method");
        }
        public void NullDemo()
        {
            //Console.WriteLine("Please enter your age");
            int? age = null;
            Console.WriteLine("Age is:"+age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo.show();
            Console.WriteLine(Demo.x);
            Console.WriteLine("Nullable type & Var example");
            Demo obj = new Demo();
            obj.NullDemo();
        }
    }
}
