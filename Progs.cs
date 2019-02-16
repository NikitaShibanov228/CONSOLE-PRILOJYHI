using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;
using MySql.Data.MySqlClient;
using System.Data.Common;


namespace WindowsFormsApp6
{
    class Program1
    {
        public static void Main1()
        {
            int age = 23;
            string sqlExpression = "Delete FROM test WHERE Qeq = 4444";
            Console.WriteLine("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlExpression, conn);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Удалено объектов: {0}", number);


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }

}