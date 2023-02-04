using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace BirthdayCalander
{
    public class DataFunctions
    {
        public void SaveBirthday(Birthday birthday) 
        {
            var SaveNewBirthdayQuery = "";
            MySqlConnection connection = new MySqlConnection { ConnectionString = DatabaseSettings.Connectionstring};
            MySqlCommand command = new MySqlCommand(SaveNewBirthdayQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
        }  
    }
}
