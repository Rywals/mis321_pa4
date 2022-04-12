using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers1
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        [EnableCors("OpenPolicy")]
        [HttpGet]
        
        public string Get(){
            // List<Song> temp = new List<Song>(){};
            // return temp;
            return "test";
        }

        [EnableCors("OpenPolicy")]
        [HttpGet]
        public void Post(){

        }

        [EnableCors("OpenPolicy")]
        [HttpGet]

        public void Put(){

        }

        [EnableCors("OpenPolicy")]
        [HttpGet]

        public void Delete(){

        }
    }
}
