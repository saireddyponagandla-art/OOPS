using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student
    {
        public void StudentDetails() {
            Console.WriteLine("Enter the Student id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name is:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age is:");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                StudentDe(id, name, age);
                StudentDetails();
                Student.College();
            }
            


        }
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
 
            {
                Student student = new Student();
                student.StudentDetails();
   
            }
        }

    }
}
