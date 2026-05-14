//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

//namespace OOPS
//{
//    internal class Array
//    {
//        static void Main(string[] args)
//        {
//            int[] marks = new int[3];
//            string [] names = new string[3];
//            int[ ] age = new int[3];
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Enter the marks:");
//                marks [i] = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter the Name:");
//                names [i] = Console.ReadLine();
//                Console.WriteLine("Enter the age:");
//                age[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("Enter the Student name search");
//             string search = Console.ReadLine();
//            for (int j = 0; j < 3; j++)
//            {
//                if (search == names[j])
//                {
//                    Console.WriteLine("Student name is:"+names[j]);
//                    Console.WriteLine("Student Marks is :"+marks[j]);
//                    Console.WriteLine("Student age is :" + age[j]);

//                }
//            }
//        } 
//    }
//}
