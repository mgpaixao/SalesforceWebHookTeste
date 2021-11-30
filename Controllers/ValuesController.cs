using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SalesforceWebHook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static SalesforceWebHook.Models.LeadRequest;
using static SalesforceWebHook.Models.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesforceWebHook.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _map;

        public ValuesController(IMapper map)
        {
            _map = map;

        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("lead")]
        public ResponseNew Post(Object value)
        {            

            Root res = JsonConvert.DeserializeObject<Root>(value.ToString());
                      

            var x = _map.Map<ResponseNew>(res.@new.FirstOrDefault());

            return x;
        }
    }
}
