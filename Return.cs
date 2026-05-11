
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Return
    {
        public int sum()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            return c;
          }
        /*  with return type without parameters */


        static void Main(string[] args)
        {
            Return re = new Return();
            int result = re.sum();
        }
    }
}
