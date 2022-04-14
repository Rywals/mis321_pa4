using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Database;
using api.Interfaces;

namespace api.Controllers1
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        [EnableCors("OpenPolicy")]
        [HttpGet]
        
        public List<Song> Get(){
            IReadSong readSong = new ReadSong();
            List<Song> temp = readSong.Read();
            return temp;
        }

        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Song value){  
            ICreateSong createSong = new CreateSong();
            createSong.Create(value.SongTitle);
        }

        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]

        public void Put(int id, [FromBody] Song value){
            IUpdateSong updateSong = new UpdateSong();
            updateSong.Update(id);
        }

        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]

        public void Delete(int id, [FromBody] Song value){
            IDeleteSong deleteSong = new DeleteSong();
            deleteSong.Delete(id);
        }
    }
}
