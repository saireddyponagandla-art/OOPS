//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Program
//    {
//        public int id;
//        public  string name;
//         static string College;
//        public Program()
//        {
//            id = 0;
//            name = "saikumar";
//            College = "ABC College";
//        }
//        public Program(int sid,string sname,string scollege)
//        {
//            id = sid;
//            name = sname;
//           College = scollege;
//        }
//        public void StudentD()
//        {
//            Console.WriteLine("Student id is: " + id);
//            Console.WriteLine("Student name is: " + name);
//            Console.WriteLine("Student college is: " + College);
//        }
//        public void Marks()
//        {
//            int M1 = 80, M2 = 90, M3 = 85;
//            int total = M1 + M2 + M3;
//            int avg = (M1 + M2 + M3) / 3;
//            Console.WriteLine("Total marks is: " + total);
//            Console.WriteLine("Average marks is: " + avg);
//        }

//    }
//    internal class ExParameter
//    {
//        static void Main(string[] args)
//        {
//            Program p1 = new Program(1, "sai", "ABC College");
//            Program p2 = new Program(2, "Raju", "ABC College");
//            p1.StudentD();
     
//            p2.StudentD();
//            Program p = new Program();
//            p.StudentD();
//        }

//    }
//}
