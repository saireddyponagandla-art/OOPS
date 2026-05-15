//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{

//    class Employee
//    {
//        int empid;
//        string empname;
//        float salary;
//        static string Companyname;
//        float hikeSalary = 0;
//        public Employee()
//        {
//            empid = 101;
//            empname = "sai kumar";
//            salary = 50000;
//            Companyname = "abc it solution";
//        }
//        public void hike()
//        {
//            float hikeSalary = 0;
//            hikeSalary = salary * 0.10f + salary;

//            Console.WriteLine("After hike salary is:" + hikeSalary);
//        }
//        public void EmployeeDetails()
//        {
//            Console.WriteLine("Employee id is:" + empid);
//            Console.WriteLine("Employee name is:" + empname);
//            Console.WriteLine("Employee salary is:" + salary);
//            Console.WriteLine("Company name is:" + Companyname);
//            Console.WriteLine("Hike salary is:" + hikeSalary);

//        }

//    }
//    internal class ConstractorEx1
//    {
//        static void Main(string[] args)
//        {
//            Employee obj = new Employee();
//            obj.EmployeeDetails();
//            obj.hike();
//        }
//    }
//}
