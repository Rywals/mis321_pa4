using api.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using api.Models;
using System.Collections.Generic;

namespace api.Database
{
    public class ReadSong : IReadSong
    {
        public List<Song> Read()
        {
            List<Song> playlist = new List<Song>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM songs";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()){
                Song temp = new Song(){SongID = rdr.GetInt32(0), SongTitle = rdr.GetString(1), SongTimestamp = rdr.GetDateTime(2), Favorited = rdr.GetString(3)};
                playlist.Add(temp);
            }
            
            return playlist;
        }
    }
}