using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   
        class ThisKey
        {
            int a;
            int b;
         
        public  ThisKey(int a, int b)
            {
            this.a = a;
            this.b = b;

            }
            public  void Add()
            {
            int c = a + b;
                Console.WriteLine("sum of a &b is:" + c);
            }
        }
    internal class ThisKeyword
    {
        static void Main(string[] args)
        {
            ThisKey th = new ThisKey(10,20);
            th.Add();

        }
    }
}
