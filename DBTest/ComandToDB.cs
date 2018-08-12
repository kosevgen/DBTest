using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{

    class ComandToDB
    {

        public void FirstTestDB() {

            PublicConnectionToMSDB.ConnectionOpen();
            Console.WriteLine("\n\n\nStart TestDB\n\n\n");
            PublicConnectionToMSDB.ConnectionClose();
        }
        //CREATE TABLE IF NOT EXISTS ИМЯ_ТАБЛИЦЫ
        public void RunComand(string comand) {

            SqlCommand readDataFromDB = PublicConnectionToMSDB.conn.CreateCommand(); //PublicConnectionToMSDB.ConnectionToMSDB().CreateCommand();
            readDataFromDB.CommandText = comand;
            SqlDataReader dataReader = readDataFromDB.ExecuteReader();
            
            while (dataReader.Read())
            {

                Console.WriteLine(Convert.ToString(dataReader[1]) + " " +
                    Convert.ToString(dataReader[2]) + " " +
                    Convert.ToString(dataReader[3]) + " " +
                    Convert.ToString(dataReader[4]) + " " +
                    Convert.ToString(dataReader[5]) + " " +
                    Convert.ToString(dataReader[6]));

            }
            Console.ReadKey();
            
        }
        public void TestTableLogin()
        {

            

        }






    }

}
       


