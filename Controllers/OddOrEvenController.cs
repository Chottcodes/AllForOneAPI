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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController(OddOrEvenServices oddOrEvenServices){
            _oddOrEvenServices = oddOrEvenServices;
        }
        [HttpGet]
        [Route("OddorEven/{Number1}")]
         public string OddOrEvenResult(string Number1){
            return _oddOrEvenServices.OddOrEvenResult(Number1);
         }
    }
}