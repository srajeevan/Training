using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Generics
{
    class Generic<T>
    {
        public T Gvariable1;
        public T Gmethod(T gvar2)
        {
            Gvariable1 = gvar2;
            return Gvariable1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<string> gobj = new Generic<string>();
            String msg=gobj.Gmethod("Sreejith");
            Console.WriteLine("Hello " + msg);
        }
    }
}
