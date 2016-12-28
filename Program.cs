using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    abstract class Repository
    {
        public abstract void Show();
        public void showMessage()
        {
            Console.WriteLine("Hi Sreejith-Message from non abstract method");
        }
               
    }
    class Program:Repository
    {
        public override void Show()
        {
            Console.WriteLine("Abstract method");
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Show();
            Repository rp = new Program();
            rp.Show();
            pg.showMessage();

        }
    }
}
 