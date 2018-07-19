using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            GrowCat(ref c);
            Console.WriteLine(c.Age);

            Lion l = new Lion();
            GrowLion(ref l);
            Console.WriteLine(l.Age);

            foo();
        }

        private static void foo()
        {
            Lion l1 = new Lion();
        }

        static void GrowLion(ref Lion a)
        {
            a.Age++;
        }

        static void GrowCat(ref Cat a) // overloading
        {
            a.Age++;
        }
    }
}
