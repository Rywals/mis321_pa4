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
        public void Create(){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"Insert INTO songs(id, title, timestamp, removesong) VALUES(@id, @title, @timestamp, @removesong)";

            using var cmd = new MySqlCommand(stm, con);
            
            cmd.Parameters.AddWithValue("@id", 1);
            cmd.Parameters.AddWithValue("@title", "test");
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
            cmd.Parameters.AddWithValue("@removesong", "n");

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}