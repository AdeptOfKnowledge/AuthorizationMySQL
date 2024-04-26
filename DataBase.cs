using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = savinan");

        /* string connectionString = @"Data Source= NCMBW832\SQLEXPRESS; Initial Catalog = kk_start; Integrated Security = SSPI; Connect Timeout = 15;" +
         "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"; // строка подключения
        SqlConnection Con = new SqlConnection(connectionString); //Новое подключение
        SqlCommand command = new SqlCommand("SELECT UserName FROM [User]", Con); //Команда выбора данных */

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
