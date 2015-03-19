using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo
{
    public class SumClass
    {
        public int TheSum { get; set; }

        public SumClass(int x, int y)
        {
            // Good line
            TheSum = x + y;

            // Uh-oh, a bug!
            //TheSum++;
        }
    }
}
