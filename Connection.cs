//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using MySql.Data.MySqlClient;

////class Program
//{
//    static void Main()
//    {
//        // Replace with your XAMPP MySQL database details
//        string server = "localhost"; // XAMPP typically uses localhost
//        string database = "events"; // Replace with your database name
//        string username = "root"; // Default XAMPP username
//        string password = ""; // Default XAMPP password is empty

//        string connectionString = $"Server={server};Database={database};User ID={username};Password={password};";

//        using (MySqlConnection connection = new MySqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection successful!");
//            }
//            catch (MySqlException ex)
//            {
//                Console.WriteLine($"Connection failed: {ex.Message}");
//            }
//        }
//    }
//}

