using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class NoreturnWithoutPara

    /*     No Return Type and also  Without Parameter    */
    {
        class oops
        {
            public void greet()
            {
                Console.WriteLine("hello Dot net Developer");
            }
        }
        static void Main(string[] args)
        {
            oops ob = new oops();
            ob.greet();

        }
    }
}
