using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ApolloConfigureCenter.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IConfiguration _configuration;
        public ValuesController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get(string key = "title")
        {
            var value = _configuration.GetValue<string>(key);
            return Ok($"key:{key} value:{value}");
        }


    }
}
