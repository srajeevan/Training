using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Overriding
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Display method of Class A");
        }
    }
    class B:A
    {
         public override void Show()
        {
            Console.WriteLine("Display method of Class B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1.Show();
            A obj2 = new B();
            obj2.Show();
        }
    }
}
