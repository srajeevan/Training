using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_BoxingandUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;//Boxing
            Console.WriteLine("Boxed output:"+o);

            int j = (int)o;
            Console.WriteLine("Unboxed Output:" + j);
            Console.WriteLine("Demo of String and String Builder");
            string str = "Hello";
            Console.WriteLine(str);
            str = "world";
            Console.WriteLine(str);
            StringBuilder stb = new StringBuilder("Hell0");
            stb.Append("world");
            Console.WriteLine(stb);

        }
    }
}
