using Cafe_Lazar.Server.Model;
using Cafe_Lazard.Server.Interface;
using Cafe_Lazard.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_Lazar.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinkController : ControllerBase
    {

        private readonly ILogger<DrinkController> _logger;
        private IDrinkService DrinkService;

        public DrinkController(ILogger<DrinkController> logger, IDrinkService drinkService)
        {
            _logger = logger;
            DrinkService= drinkService;
        }

        [HttpGet(Name = "GetListOfDrink")]
        public IEnumerable<Drink> GetListOfDrink()
        {
           return DrinkService.GetallDrinks();
        }
       
    }
}
