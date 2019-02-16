using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tutorial.SqlConn;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            zzz();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void zzz()
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
                
                textBox1.Text = "Удалено объектов: {0}" + number;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}
