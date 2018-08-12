//
//
//

using System;
using System.Data.SqlClient;


namespace DBTest
{
    public class PublicConnectionToMSDB
    {
        public static string connectionString = @"Data Source = 192.168.70.3; Initial Catalog = DBForTests; Persist Security Info=True;User ID= sa; Password= ASDqwe!@#;";

        public static SqlConnection ConnectionToMSDB()
        {

            SqlConnection connectionToDB = new SqlConnection(connectionString);
            return connectionToDB;

        }

        public static SqlConnection conn = ConnectionToMSDB();

        public static void ConnectionOpen()
        {
            
            try
            {

                Console.Write("Establish connection to DB ... ");
                conn.Open();
                Console.Write(" COMPLITE " + "\n" + "\n\n\n Press any key ");
                Console.ReadKey();
                
            }
            catch (Exception ex)
            {

                Console.Write("Error during establish connection to DB " + ex + "\n\n\n Press any key ");
                Console.ReadKey();

            }
            

        }

        public static void ConnectionClose()
        {

            try
            {

                Console.Write("Closing connection to DB ... ");
                conn.Close();
                Console.Write(" COMPLITE " + "\n" + "\n\n\n Press any key ");
                Console.ReadKey();

            }
            catch (Exception ex)
            {

                Console.Write("Error during closing connection to DB " + ex + "\n\n\n Press any key ");
                Console.ReadKey();

            }

        }


    }
}
