using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_exception
{
    class Divison
    {
        int answer;
        public void divideNumbers(int a,int b)
        {
            try
            {
                answer = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Excaption :"+e);
            }
            finally
            {
                Console.WriteLine("Answer is "+answer);
            }
            
        }
        static void Main()
        {
            Divison dm = new Divison();
            dm.divideNumbers(10,0);
        }
    }
}
