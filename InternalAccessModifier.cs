//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class MyClass
//    {
//       internal int a;
//        string b;
//        float h;
//        internal MyClass()
//        {
//            a = 10;
//            b = "mahesh";
//            h = 5.6f;
//        }
//        public MyClass(int aa, string bb, float hh)
//        {
//            a = aa;
//            b = bb;
//            h = hh;
//        }


//        public void Display()
//        {
//            Console.WriteLine("a  is :" + a);
//            Console.WriteLine("b is :" + b);
//            Console.WriteLine("h is :" + h);
//        }
//    }
//    class NewClass
//    {

//        public void MyMethod()
//        {
//            MyClass ob = new MyClass();
//            Console.WriteLine(ob.a);// it will print the class name because we have not override the tostring method
//            // if we want to print the values of the class then we have to override the tostring method in the class
//            // when we create the object of the class then it will call the tostring method and it will print the values of the class
//        }
//    }
//    internal class InternalAccessModifier
//    {
//        static void Main(string[] args)
//        {
//            MyClass ob = new MyClass();
//            ob.Display();
//            //MyClass ob1 = new MyClass(100,"suresh", 5.4f);
//            //ob1.Display();
//            NewClass ob2 = new NewClass();
//            ob2.MyMethod();

//        }
//    }


//}