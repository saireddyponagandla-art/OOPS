using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student
    {
        public void StudentDe(int id,string name,int age) 
        {
            Console.WriteLine("Student id is : "+id +"   Student name is : "+name+"   student age is : "+age);

        }
        public static void College()
        {
            Console.WriteLine("RN REDDY IT SCHOOL");
        }
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.StudentDe(1, "sai", 20);
            stu.StudentDe(2, "suresh", 29);
            stu.StudentDe(3, "mahesh", 28);
            stu.StudentDe(4, "chenna", 27);
            stu.StudentDe(5, "akash", 23);
            Student.College();
        }

    }
}
