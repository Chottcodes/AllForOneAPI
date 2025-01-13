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
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumberServices _reverseItNumbersServices;
        public ReverseItNumbersController(ReverseItNumberServices reverseItNumberServices)
        {
            _reverseItNumbersServices = reverseItNumberServices;
        }
        [HttpGet]
        [Route("Reversenumber/{Number1}")]
        public string ReverseNumbers(string Number1){
            
            return _reverseItNumbersServices.ReverseNumbers(Number1);
        }
    }
}