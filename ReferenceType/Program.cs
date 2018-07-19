using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {
        static int MAX = 4;

        static void Main(string[] args)
        {
            short a = 1;
            short b = 2;
            Swap(&a, &b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            return;


            Lion l = new Lion();
            GrowLion(l);
            Console.WriteLine(l.Age);

            Cat c = new Cat();
            GrowCat(c);
            Console.WriteLine(c.Age);
        }

        static void Swap(short* i, short* j)
        {
            //short i = 1;
            //short j = 2;

            short t = *i;
            *i = *j;
            *j = t;
        }

        static void GrowLion(Lion a)
        {
            a.Age++;
        }

        static void GrowCat(Cat a) // overloading
        {
            a.Age++;
        }
    }
}
