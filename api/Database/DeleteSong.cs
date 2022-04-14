using api.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace api.Database
{
    public class DeleteSong : IDeleteSong
    {
        public void Delete(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DELETE FROM songs WHERE song_id = @song_id";
            
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@song_id", id);
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