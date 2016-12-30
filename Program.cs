using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    

    class Program:IDisposable
    {
        int x;
        int y;
        bool disposed = false;
        public Program()
        {
            this.x = 0;
            this.y = 0;
        }
        public Program(int a,int b)//constructor
        {
            this.x = a;
            this.y = b;
        }
        public void Dispose()//Dispose
        {
            Dispose(true);
            GC.SuppressFinalize(this);//finalize
        }
        protected void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    Console.WriteLine("clean up managed code");
                }
                Console.WriteLine("clean up unmanaged code");
                disposed = true;
            }

        }
        static void Main(string[] args)
        {
            Program pg = new Program(2,3);
            pg.Dispose();
        }
    }   
}
