using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ParameterRealworldEx
    {
        class DataBaseConnection
        {
            // It has a constructor that initializes the connection string and creates a SqlConnection object.
            // The class also has two methods: openconnection() to open the database connection and closeConnection() to close it.
            // The Main method demonstrates how to use the DataBaseConnection class by creating an instance with a connection string,
            // opening the connection, and then closing it.


            String Connectionstring;// it is used to store the connection string that is passed as a parameter to the constructor.
            SqlConnection connection;// it is used to establish a connection to a database using the provided connection string.
            public DataBaseConnection(String connectionstring)// it is a constructor that takes a connection string as a parameter and initializes the Connectionstring
                                                              // field and creates a SqlConnection object using the provided connection string.
            {
                Connectionstring = connectionstring;// it assigns the value of the connectionstring parameter to the Connectionstring field of the class.
                connection = new SqlConnection(Connectionstring);// it creates a new instance of the SqlConnection class using the provided
                                                                 // connection string and assigns it to the connection field of the class.

            }
            public void openconnection()// it is a method that attempts to open the database
                                        // connection using the Open() method of the SqlConnection class.
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(" DataBase Connection will be opened Successfully ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            public void closeConnection()// it is a method that checks if the database connection is open and,
                                         // if so, closes it using the Close() method of the SqlConnection class.
            {
                if (connection.State == System.Data.ConnectionState.Open)// it checks if the state of the connection is open before attempting to close it.
                {
                    connection.Close();
                    Console.WriteLine("DataBase Connection is Closed");
                }
            }

            static void Main(string[] args)
            {
                string Connstring = "server =saireddy_2005\\SQLEXPRESS;Initial Catalog=DP1;Integrated Security=True;";
                DataBaseConnection db = new DataBaseConnection(Connstring);// it creates an instance of the DataBaseConnection class,
                                                                           // passing the connection string as a parameter to the constructor.
                db.openconnection();// it calls the openconnection() method to open the database connection.

                db.closeConnection();// it calls the closeConnection() method to close the database connection.

            }
        }
    }
}
