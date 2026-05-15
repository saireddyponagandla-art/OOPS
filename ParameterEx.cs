//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Student
//    {
//        int sid;
//        string sname;
//        int sfee;
//        static string schoolname = "ABC school";
//        public Student(int Sid, string Sname, int Sfee)
//        {
//           sid = Sid;
//            sname = Sname;
//            sfee = Sfee;
//        }
//        public void StudentDetails()
//        {
//            Console.WriteLine("Student Id:" + sid);
//            Console.WriteLine("Student name is :" + sname);
//            Console.WriteLine("Student fee is:" + sfee);
//            Console.WriteLine("Student College name is:" + schoolname);
//        }
//    }
//    internal class ParameterEx
//    {
//        static void Main(string[] args)
//        {
//            Student obj = new Student(101, "abc", 23000);
          
//            obj.StudentDetails();

//            Student obj1 = new Student(102, "aaaaaaaa",23943);

//            obj1.StudentDetails();
//            Student obj2 =new Student(103,"bbb",45000); 
//            obj2.StudentDetails();
//        }
//    }
//}
