using api.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace api.Database
{
    public class DeleteSong : IDeleteSong
    {
        public void Delete()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP ROW IF EXISTS songs";
            
            using var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery(); 
        }

        public void DropTable()
        {
             ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS songs";
            
            using var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
        }
    }
}