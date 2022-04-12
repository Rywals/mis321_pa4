using api.Models;
using System.Collections.Generic;

namespace api.Interfaces
{
    public interface IReadSong
    {
        public List<Song> Read(); 
    }
}