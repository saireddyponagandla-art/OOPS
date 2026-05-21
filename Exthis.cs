//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class thisEx
//    {
//        public int id;
//        public string name;
//        public float sal;
//        static string Company;

//        public thisEx(int id, string name, float sal)
//        {
//            this.id = id;
//            this.name = name;
//            this.sal = sal;
//            Company = "ABC Company";


//        }
//        public void Static()
//        {
//            Console.WriteLine("This is a Static KeyWord");
//            Console.WriteLine(Company);
//        }
//        public void Details()
//        {
//            Console.WriteLine("Id is " + id);
//            Console.WriteLine("Name is " + name);
//            Console.WriteLine("Salary is" + sal);
//            Console.WriteLine(" Company name is static name " + Company);
//        }
//    }



//    internal class Exthis
//    {
//        static void Main(string[] args)
//        {
//            thisEx ob = new thisEx(101, "PAVAN", 35699.99F);
//            ob.Static();
//            ob.Details();


//            //Another object 
//            thisEx obj = new thisEx(102, "suresh", 444444);
//            obj.Details();
//            obj.Static();

//        }


//    }
//}

