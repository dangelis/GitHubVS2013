using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SumClass adder = new SumClass(2, 2);
            Console.WriteLine("The sum is {0}!", adder.TheSum);
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
