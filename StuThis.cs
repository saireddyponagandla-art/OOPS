using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    class Student
    {
        int stid;
        string stname;
        static string college = "  XYZ college";
        public Student (int stid) /// first constrtor passing value is only stid 
        {

            this.stid = stid;
        }
        public Student(string stname)//  second Constor passing one value that is stname  other values must be detalu values
        {
            this.stname = stname;
        }
        public  Student(int stid, string stname)// thrid constrator is passing both values  to display vlaues.
        {
            this.stid = stid;
                this.stname = stname;
           

        }
        public void Enduser()
        {
            Console.WriteLine("enter a Student name :");
            string Name  = Console.ReadLine();
            Console.WriteLine("Enter Student Id :");
            int Sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("takes the static College Name!");
            
            Console.WriteLine("Student Name Is" + Name);
            Console.WriteLine("Student Id is:"+Sid);
            Console.WriteLine("Student College Name is" + college);
        }
        public void StuDet() /// Method calling a Method then display output 
        {
            Console.WriteLine("Student id is " + stid);
            Console.WriteLine("Student name is :" + stname);
            Console.WriteLine("Student College name is " + college);
        }
    }
    internal class StuThis
    {
        static void Main(string[] args)
        {
            Student st = new Student(23);
            st.StuDet();
            Student st1 = new Student("siri");
            st1.StuDet();
            Student st2 = new Student(1, "asd");
            st2.StuDet();
            st2.Enduser();
           
        }

    }
}
