using System.Collections.Generic;
using api.Models;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using api.Interfaces;

namespace api.Database
{
    public class CreateSong : ICreateSong
    {
        public List<Song> Playlist {get; set;}
        public void Create(string value){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"Insert INTO songs(title, time_stamp, favorite) VALUES(@title, @time_stamp, @favorite)";

            using var cmd = new MySqlCommand(stm, con);
            
            //cmd.Parameters.AddWithValue("@id", 1);
            cmd.Parameters.AddWithValue("@title", value);
            cmd.Parameters.AddWithValue("@time_stamp", DateTime.Now);
            cmd.Parameters.AddWithValue("@favorite", "n");

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}