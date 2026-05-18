//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class ExofParameter
//    {
//        class Car
//        {
//            string carname;
//            string carcolor;
//            int carmodel;
//            float carprice;

//            public Car()// it is default constructor
//                        // it will assign the default values to the fields
//            {
//                carname = "BMW";
//                carcolor = "Black";
//                carmodel = 2020;
//                carprice = 5000000;
//            }
//            public Car(string Carname, string Carcolor, int Carmodel, float Carprice)// it is parameterized constructor
//                                              // it will assign the values to the fields which are passed as parameters
//            {
//                carname = Carname;
//                carcolor = Carcolor;
//                carmodel = Carmodel;
//                if (Carmodel >= 1886)
//                {
//                    Console.WriteLine("carmodel is:"+carmodel);

//                }
//                else
//                {
//                    Console.WriteLine(carmodel+"this year not  inviting");
//                }
//               carprice = Carprice;
//            }
            
//            public void DisplayCaeDetails()// it is method to display the details of the car
//            {
//                Console.WriteLine("car name is :" + carname);
//                Console.WriteLine("car color is :" + carcolor);
//                //Console.WriteLine("car model is:"+ carmodel);
//                Console.WriteLine("car price is:" + carprice);
//            }
          

//        }
//        static  void Main(string[] args)
//        {
//            //Car ob = new Car();
//            //ob.DisplayCaeDetails();
//            Car ob1 =new Car("Suzuki", "Red",1800,300000);
//            ob1.DisplayCaeDetails();
//            //Car ob2 = new Car("Mahindra", "White", 1800, 400000);
//            //ob2.DisplayCaeDetails();
//        }
//    }
//}
