using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    class Student
    {
        int stid;
        string stname;
        static string college;
        public  Student(int stid, string stname)
        {
            this.stid = stid;
                this.stname = stname;
            college = "  XYZ college";

        }
        //public void Static()
        //{
        //    Console.WriteLine("College Name is"+college);
        //}
        public void StuDet()
        {
            Console.WriteLine("Student id is " + stid);
            Console.WriteLine("Student name is :" + stname);
            Console.WriteLine("Student College name is " + college);
        }
    }
    internal class StuThis
    {
        static void Main(string[] args)
        {
            Student st = new Student(23, "sai");
            st.StuDet();
            Student st1 = new Student(1, "asd");
            st1.StuDet();
           
        }

    }
}
