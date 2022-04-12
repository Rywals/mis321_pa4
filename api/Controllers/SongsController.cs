using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Database;

namespace api.Controllers1
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        [EnableCors("OpenPolicy")]
        [HttpGet]
        
        public List<Song> Get(){
            ReadSong readSong = new ReadSong();
            List<Song> temp = readSong.Read();
            return temp;
        }

        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post(){

        }

        [EnableCors("OpenPolicy")]
        [HttpPut]

        public void Put(){

        }

        [EnableCors("OpenPolicy")]
        [HttpGet]

        public void Delete(){

        }
    }
}
