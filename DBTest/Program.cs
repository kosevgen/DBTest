using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            PublicConnectionToMSDB.ConnectionOpen();
            TestDBStructure testDBStructure = new TestDBStructure();
            testDBStructure.RunComand("SELECT * FROM DBForTests.dbo.HumanInfo");
            PublicConnectionToMSDB.ConnectionClose();

         }
    }
}
////PublicConnectionToMSDB publicConnection = new PublicConnectionToMSDB();
//SqlConnection conn = PublicConnectionToMSDB.ConnectionToMSDB();
////TestDBStructure testDB = new TestDBStructure();
////testDB.FirstTestDB();
////testDB.RunComand("SELECT * FROM DBForTests.dbo.HumanInfo");

//try
//{

//    Console.Write("Establish connection to DB ... ");
//    conn.Open();
//    Console.Write(" COMPLITE " + "\n");
//    Console.ReadKey();

//}
//catch(Exception ex) {

//    Console.Write("Error during establish connection to DB " + ex);
//    Console.ReadKey();

//}

////do something
//try {

//    SqlCommand readAllDataFromDB = conn.CreateCommand();
//    readAllDataFromDB.CommandText ="SELECT * FROM DBForTests.dbo.HumanInfo";
//    SqlDataReader dataReader = readAllDataFromDB.ExecuteReader();
//    while (dataReader.Read()) {

//        Console.WriteLine(Convert.ToString( dataReader[1]) + " " + 
//            Convert.ToString(dataReader[2]) + " " + 
//            Convert.ToString(dataReader[3]) + " " + 
//            Convert.ToString(dataReader[4]) + " " + 
//            Convert.ToString(dataReader[5]) + " " + 
//            Convert.ToString(dataReader[6]));

//    }
//    Console.ReadKey();

//}
//catch (SqlException sqex) {

//    Console.WriteLine(sqex);

//}

//try
//{

//    Console.Write("Closing connection to DB ... ");
//    conn.Close();
//    Console.Write(" COMPLITE " + "\n");
//    Console.ReadKey();

//}
//catch (Exception ex) {

//    Console.Write("Error during closing connection to DB " + ex);
//    Console.ReadKey();

//}