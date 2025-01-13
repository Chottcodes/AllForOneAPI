using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseitAlphaServices _reverseItAlphaServices;
        public ReverseItAlphaController(ReverseitAlphaServices reverseitAlphaServices)
        {
            _reverseItAlphaServices = reverseitAlphaServices;
        }
        [HttpGet]
        [Route("Reversestring/{input}")]
        public string reversestring(string input){
         return _reverseItAlphaServices.reversestring(input);
       
       }
    }
}