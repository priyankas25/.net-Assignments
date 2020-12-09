using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple interest...
            Func<int, int, int, int> o = (p, n, r) => p * n * r / 100;

            Func<int, int, bool> o1 = ( l, m) => l > m;

            Predicate<int> o2 = a => a % 2 == 0;

            Console.WriteLine(o(3000,4,5)+" "+o1(6,5)+" "+o2(7));
            Console.ReadLine();
        }
    }
}
