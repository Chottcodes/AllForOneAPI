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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsService;
        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices)
        {
            _askingQuestionsService = askingQuestionsServices;
        }
        [HttpGet]
        [Route("Asking/{Name}/{Time}")]
        public string AskingQuestion(string Name, int Time){
            return _askingQuestionsService.AskingQuestion(Name,Time);
        }
    }
}