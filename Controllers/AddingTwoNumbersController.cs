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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;
        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersServices){
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }
        [HttpGet]
        [Route("Adding/{Number1}/{Number2}")]
        public string AdddingNumbers(string Number1, string Number2){
            return _addingTwoNumbersServices.AdddingNumbers(Number1,Number2);
        }
    }
}