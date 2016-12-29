using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new//var implicit typed variable
            {
                sid = 001,
                sname = "John",
                sage = 20

            };
            Console.WriteLine("Demo of Var and Anonymous type");
            Console.WriteLine("Stduent Details: Student Id={0},Stduent Name:{1},Student Age:{2}",student.sid, student.sname, student.sage);
        }
    }
}
