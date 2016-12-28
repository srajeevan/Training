using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Delegates
{
    delegate void showDetails(string mesaage);
    class Student
    {
        public void GetMessage1(string m)
        {
            Console.WriteLine(m);
        }
        public void GetMessage2(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student st = new Student();
            showDetails sd = new showDetails(st.GetMessage1);
            showDetails sd1 = new showDetails(st.GetMessage1);
            sd1 += st.GetMessage2;
            sd("Hello World-from delegate");//delgate
            sd1("multicast delegate");//multicast delegate
        }
    }
}
