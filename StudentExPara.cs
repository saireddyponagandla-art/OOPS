using OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    class StudentExPar
    {
        int id;
        string name;
        int age;

        public StudentExPar(int Suage)
        {
            age = Suage;
        }
        public StudentExPar(int Sid, string Sname)
        {
            id = Sid;
        }
        public StudentExPar(int STid, string name, int Sage)
        {
            id = STid;
            string name1 = name;
            age = Sage;
        }
        public StudentExPar()
        {
            id = 101;
            name = "mahesh";
            age = 20;
        }
        public void StudentDetails()
        {
            Console.WriteLine("Student Id is:" + id);
            Console.WriteLine("student name is :" + name);
            Console.WriteLine("Student age is :" + age);
        }
    }

    internal class StudentExPara
    {
        static void Main(string[] args)
        {
           StudentExPar ex=new StudentExPar();
            ex.StudentDetails();
             StudentExPar ex1 = new StudentExPar(102, "suresh", 21);    
            ex1.StudentDetails();
             StudentExPar ex2 = new StudentExPar(103, "ramesh");
            ex2.StudentDetails();
             StudentExPar ex3 = new StudentExPar(22);


        }
    }
}

