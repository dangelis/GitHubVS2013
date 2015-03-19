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
            var x = 2;
            var y = 2;

            SumClass adder = new SumClass(x, y);
            Console.WriteLine("The sum is {0}!", adder.TheSum);

            if (adder.TheSum != x + y)
            {
                var fileName = @"C:\Users\Public\tmpTest\CIDemoOut.txt";
                Console.WriteLine("Unexpected sum, writing to {0}!", fileName);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
                {
                    file.WriteLine(adder.TheSum);
                }
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
