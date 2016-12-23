using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public enum operation
    {
        Plus,
        Minus,
        Multiply,
    };
    class Parent
    {
        private int n;
        public int MyProperty
        {
            get;
            set;
        }
        public string message="Operation completed";
        public void show()
        {
            Console.WriteLine(message);
        }
    }
    class Calculate:Parent
    {

        public void compute(int a,int b,operation op)
        {
            
            int i = (int)op;
            switch (i)
            {
                case 0:
                    int val1 = a + b;
                    //Console.WriteLine(sum);
                    Console.WriteLine("it is plus" + " and output is "+val1);
                    break;
                case 1:
                    if (a > b)
                    {
                               Console.WriteLine("in if loop");
                       int val2 = a - b;
                        Console.WriteLine("it is minus" + " and output is " + val2);
                    }
                    else
                    {
                        Console.WriteLine("in else loop");
                        int val2 = b - a;
                        Console.WriteLine("it is minus" + " and output is " + val2);
                    }
                    
                    break;
                default:
                    string result = i == 2 ? "Multiply operator will be implemented soon" : "Invalid Operator";
                    Console.WriteLine(result);
                    break;

            }
        }

    }
    class Test
    {
        public static void Main()
        {

            Calculate cal1 = new Calculate();
            Console.WriteLine("Enter two numbers and an operator");
            Console.WriteLine("0 : Plus");
            Console.WriteLine("1 : Minus");
            Console.WriteLine("2 : Multiply");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            operation en = (operation)e;
            cal1.compute(a,b,en);
            cal1.show();
        }
    }
}
