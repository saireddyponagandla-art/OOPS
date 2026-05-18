//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class StudentEX
//    {
//        class Student
//        {
//            int studid;
//            string stname;
//            int age;
//            float stheight;
//            public Student()
//            {
//                studid = 101;
//                stname = "mahesh";
//                age = 20;
//                stheight = 5.6f;

//            }
//            public Student(int Studid, string Stname, int StAge, float Stheight)
//            {
//                stname = Stname;
//                studid = Studid;
//                age = StAge;
//                stheight = Stheight;
//                if(age >18 && age < 60)
//                {
//                    Console.WriteLine("the" + stname + "is " + age);
//                }
//                else
//                { 
//                    Console.WriteLine("give me student age between 18 to 60");
//                }
//            }
//            public void StudentDetails()
//            {
//                Console.WriteLine("Student Id is:" + studid);
//                Console.WriteLine("student name is :" + stname);
//             //   Console.WriteLine("Student age is :" + age);
//                Console.WriteLine("Student Height is :" + stheight);
//            }
//        }
//        static void Main(string [] args)
//        {
//            Student ex = new Student();
//            ex.StudentDetails();
//            Student Ex1 = new Student(101,"sai",11,5.4f);
//            Ex1.StudentDetails();
//        }
//    }
//}
