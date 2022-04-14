using api.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using api.Models;

namespace api.Database
{
    public class UpdateSong : IUpdateSong
    {
        public void Update(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm =@"UPDATE songs set favorite = @favorite where song_id = @song_id";
            using var cmd = new MySqlCommand(stm, con);
            
            cmd.Parameters.AddWithValue("@song_id", id);
            cmd.Parameters.AddWithValue("@favorite", "y");
            
            cmd.Prepare();

            cmd.ExecuteNonQuery();

        }
        public string CheckFavoriteSong(string favorite){
            if(favorite == "n"){
                return "y";
            }
            else{
                return "n";
            }
        }
    }
}