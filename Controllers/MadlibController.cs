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
    public class MadlibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadlibController(MadLibServices madLibServices){
            _madLibServices = madLibServices;
        }
        [HttpGet]
        [Route("Madlib/{cityName}/{favBacketballTeam}/{favFood}/{dreamCar}/{favCartoonChar}/{favVideoGame}/{famousPersonName}/{adjective}/{animeCharacter}/{animal}")]
         public string FunnyMadlib(string cityName, string favBacketballTeam, string favFood, string dreamCar,string favCartoonChar, string favVideoGame,string famousPersonName,string adjective,string animeCharacter,string animal){
            return _madLibServices.FunnyMadlib(cityName,  favBacketballTeam,  favFood,  dreamCar, favCartoonChar,  favVideoGame, famousPersonName, adjective, animeCharacter,animal);
            
        }
    }
}