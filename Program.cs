using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Overloading
{
    class RectArea
    {
        public void Area(int l, int b)
        {
            int Area = l * b;
            Console.WriteLine("Area of Rectangle is: " + Area);
        }
    }
    class CircleArea:RectArea
    {
        public void Area(int r)
        {
            double Area = 3.14 * r * r;
            Console.WriteLine("Area of Circle is: " + Area);
        }
    }
    class program
    {    
        static void Main(string[] args)
        {
            RectArea a1 = new RectArea();
            CircleArea a2 = new CircleArea();
            a1.Area(10, 5);
            a2.Area(5);
        }
    }
}
