using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    interface Iprint
    {
        void print();
    }
    interface Ifax
    {
        void fax();
    }
    class Program : Iprint,Ifax
    {
        public void print()
        {
            Console.WriteLine("Printing started");
        }
        public void fax()
        {
            Console.WriteLine("Faxing started");
        }
        static void Main(string[] args)
        {
            Iprint ip = new Program();
            ip.print();
            Ifax ifx = new Program();
            ifx.fax();
            Program pg = new Program();
            pg.print();
            pg.fax();
        }
    }
}
