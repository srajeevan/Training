using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HashTableandArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            foreach(DictionaryEntry x in ht)
            {
                Console.WriteLine("key{0} and value:{1}",x.Key,x.Value);
            }
            ArrayList at = new ArrayList();
            Console.WriteLine("array list values");
            at.Add(0);
            at.Add(1);
            at.Add(2);
            at.Add(3);
            at.Add(4);
            foreach(int i in at)
            {
                Console.WriteLine(i);
            }


        }
    }
}
