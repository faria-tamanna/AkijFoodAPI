using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkijFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value 1", "value 2", "value 3", "value 4" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "The value is : " + id;
        }
    }
}
