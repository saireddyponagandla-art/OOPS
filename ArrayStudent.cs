using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        int id;
        string name;
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Student id is:"+id);
            Console.WriteLine("Student name is:" + name);

            Console.WriteLine("==============================");
        }
    }
    internal class ArrayStudent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the Array Size");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
             
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n enter student Details ");
                Console.WriteLine("Enter Student Id:");
                int id= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                students[i]  = new Student(id,name);
            }
            Console.WriteLine("Student Details are:");


            for (int i = 0; i < students.Length; i++)
            {
                students[i].Display();
            }



        }
    }
}
