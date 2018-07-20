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
            Cat c1= new Cat();
            Cat c2 = c1;
            c2.Age++;
            Console.WriteLine(c1.Age);

            Lion l1 = new Lion();
            Lion l2 = l1;
            l2.Age++;
            Console.WriteLine(l1.Age);
        }
    }
}
