//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class Employee
//    {
//        public void EmployeeDetails() 
//        {
//            string[] empname = new string[5];
//            int[] empid = new int[5];
//            string[] empsal = new string[5];
//            string Company = "Abc it solution";
//            for (int i = 0; i < empname.Length; i++)
//            {
//                Console.WriteLine("Enter the Employee Name");
//                empname[i] = Console.ReadLine();
//                Console.WriteLine("Enter the Employee Id:");
//                empid[i] = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter the Employee Salary:");
//                empsal[i] = Console.ReadLine();
//                Console.WriteLine("Company name is :" + Company);

//            }

//            Console.WriteLine("Search the Employee Details with Id only:");
//            int search = Convert.ToInt32(Console.ReadLine());
//            for (int j = 0; j < empname.Length; j++)
//            {
//                if (search == empid[j])
//                {
//                    Console.WriteLine("Employee name is:" + empname[j]);
//                    Console.WriteLine("Employee id is:" + empid[j]);
//                    Console.WriteLine("Employee salary is :" + empsal[j]);
//                }

//            }

//        }


//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            emp.EmployeeDetails();
//        }
//    }
//}
