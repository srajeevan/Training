//Demo of Array,ArrayList,Foreach and While
//Arrays are of fixed length
//ArrayList is flexible array with list of objects
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Arrayist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();//Array,Array List,Foreach and While
            arr.Add(0);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            Console.WriteLine("Using Foreach loop");
            foreach (int li in arr)
            {
                Console.WriteLine(li);
            }
            int i = 0;
            Console.WriteLine(arr.Count);
            Console.WriteLine("Using While Looop");
            while (i < arr.Count)
            {

                Console.WriteLine(i);
                i++;
            }
        }
    }
}

