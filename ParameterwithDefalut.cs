//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class ParameterwithDefalut
//    {
//        class Employee
//        {
//            int eid;                //fields     or instance variable
//            string ename;      //instance variable
//            double esal;
//            public Employee()
//            {
//                //Default constructor
//                eid = 10;
//                ename ="sai";
//                esal = 50000;

//            }
//            public Employee(int Eid, string Ename, double Esal)
//            {
//                //parameterized constructor
//                eid = Eid;
//                ename = Ename;
//                esal = Esal;
//            }
//            public void EmployeeDetails()
//            {
//                //display the outputs
//                Console.WriteLine("Employee id is:" + eid);
//                Console.WriteLine("Employee name is:" + ename);
//                Console.WriteLine("Employee salary is:" + esal);
//            }
            
//        }
//        static void Main(string[] args)
//        {
//            Employee em = new Employee();
//            em.EmployeeDetails();
//            Employee emp = new Employee(101,"suresh",35000);
//            emp.EmployeeDetails();

//        }

//    }
//}
