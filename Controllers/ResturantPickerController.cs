using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResturantPickerController : ControllerBase
    {
        private readonly ResturantPickerServices _resturantPickerServices;
        public ResturantPickerController(ResturantPickerServices resturantPickerServices)
        {
            _resturantPickerServices = resturantPickerServices;
        }
        [HttpGet]
        [Route("{ChooseFoodCategory}")]
        public string Choose(string ChooseFoodCategory)
        {
            return _resturantPickerServices.FoodPick(ChooseFoodCategory);
        }
    }
}