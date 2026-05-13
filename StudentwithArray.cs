//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class StudentwithArray
//    {
//        class student
//        {
//            int id;
//            string name;
//            int age;
//            static string college = "abc college";

//            public void Getdetails()
//            {
//                Console.WriteLine("Enter the Student Id:");
//                id =Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter the Student Name:");
//                name = Console.ReadLine();
//                Console.WriteLine("Enter the Student age:");
//                age = Convert.ToInt32(Console.ReadLine());


//            }
//            public void result()
//            {
//                Console.WriteLine("Student Id is:" + id);
//                Console.WriteLine("Student Name is:"+name);
//                Console.WriteLine("Student Age:" + age);
//                Console.WriteLine("Student college name" + college);
//            }
//            public static void DisplayCollege()
//            {
//                Console.WriteLine("College name is" + college);
//            }
//            static void Main(string[] args)
//            {
//                student[] stu = new student[2];
//                for (int i = 0; i < stu.Length; i++)
//                {
//                    stu[i] = new student();
//                    stu[i].Getdetails();
//                }
//                for (int i = 0; i < stu.Length; i++)
//                {
//                    stu[i].result();
//                }
//                //student.DisplayCollege();
//            }
//        }
//    }
//}
