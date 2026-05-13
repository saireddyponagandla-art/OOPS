//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Services;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class Student1
//    {
//        public void StudentDetails()
//        {
//            Console.WriteLine("Enter the Student id: ");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Student Name is:");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter Student Age is:");
//            int age = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= 10; i++)
//            {
//                StudentDe(id, name, age);
//                Marks();
//                StudentDetails();
               

//                /* it an static way of allocation */
//                Student1.College();
              
//            }




//        }
//        public void StudentDe(int id, string name, int age)
//        {
//            Console.WriteLine("Student id is : " + id + "   Student name is : " + name + "   student age is : " + age);

//        }
//        public static void College()
//        {
//            Console.WriteLine("RN REDDY IT SCHOOL");
//        }
//        public void Marks()
//        {
           
//            Console.WriteLine("Enter the Total Stubjects:");
//            int a = Convert.ToInt32(Console.ReadLine());
//             for( int i=1;i<= a;i++)
//            {
//                Console.WriteLine("Enter each subject marks:");
//                int marks = Convert.ToInt32(Console.ReadLine());
//                a++;
               
//                Console.WriteLine( "total marks are :"+marks);
//            }

//        }
//        static void Main(string[] args)
//        {

//            {
//                Student1 student = new Student1();
//                student.StudentDetails();
               

//            }
//        }

//    }
//}
