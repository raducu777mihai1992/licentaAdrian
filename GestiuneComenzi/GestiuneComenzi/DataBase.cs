using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestiuneComenzi
{
    class DataBase
    {
        public MySqlConnection connection;

        public bool connectToDB()
        {
            try {
                connection = new MySqlConnection("Server=localhost; port=3306; Database=db_gestiunecomenzi; username=root; password=Admin; charset=utf8");
                connection.Open();
                return true;
            }
            catch(Exception ex) {
                MessageBox.Show("Unable to connect to the server: " + ex.Message);
                return false;
            } 
        }

        public bool checkUserExists(String username, String passowrd)
        {

            MySqlCommand myCommand = new MySqlCommand("select * from users", connection);
            myCommand.Connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public bool isAdmin()
        {
            return true;
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}
