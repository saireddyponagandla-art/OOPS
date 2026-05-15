//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class StudentExWithParameter
//    {
//        // class will have two constructor one is default constructor and another one is parameterized constructor
//        class student
//        {
//            int stdid;
//            string stdname;
//            double stdfee;
//            public student() // it is default constructor
//                             // it will assign the default values to the fields
//            {
//                stdid = 12;
//                stdname = "sai";
//                stdfee = 85000;
//            }
//            public student(int Stdid, string Stdname, double Stdfee) // it is parameterized constructor
//            {                           // it will assign the values to the fields which are passed as parameters
//                stdid = Stdid;
//                stdname = Stdname;
//                stdfee = Stdfee;
//            }
//            public void StudenDetails() // it is method to display the details of the student
//            {
//                Console.WriteLine("Student id is:" + stdid);
//                Console.WriteLine("Student name is:" + stdname);
//                Console.WriteLine("Student fee is:" + stdfee);
//            }
//        }
//        static void Main(string[] args)
//        {
//            student st = new student();
//            // it will call the default constructor and assign the default values to the fields
//            st.StudenDetails();
//            student std = new student(1001, "srh", 115000);
//            // it will call the parameterized constructor and assign the values to the fields
//            std.StudenDetails();
//        }
//    }
//}
