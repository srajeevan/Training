using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_AccessModifier
{
    class Demo
    {
        public void ShowName()//public
        {
            Console.WriteLine("Hi Sreejith");
        }
        private string city;
        protected internal string country;//protected internal
        protected int age;//protected
        internal void ShowDate()//internal
        {
            Console.WriteLine(DateTime.Today.Date);
        }
        public void showDetails()
        {
            Console.WriteLine("Country:" + country);
            
        }
    }
    class NewDemo: Demo
    {
        NewDemo()
        {
            this.age = 27;//accessible
            Console.WriteLine("Age is:" + age);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.ShowName();
            obj.ShowDate();
            //obj.City = "Irving"; //not accessible due to private protection level
            obj.country = "USA";//accessible
            obj.showDetails();
        }
    }
}
