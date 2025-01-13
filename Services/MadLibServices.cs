using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class MadLibServices
    {
         public string FunnyMadlib(string cityName, string favBacketballTeam, string favCartoonChar ,string dreamCar ,string adjective, string favFood,string favVideoGame, string famousPersonName,string animal, string animeCharacter)
        {
            return $"Last friday was my birthday I went to {cityName} to watch the {favBacketballTeam}. After the game {favCartoonChar} and I drove in a {dreamCar} to eat at the {adjective} {favFood}.Later we played {favVideoGame} at {famousPersonName} house and won a {animal} and named it {animeCharacter}. ";
        }
    }
}