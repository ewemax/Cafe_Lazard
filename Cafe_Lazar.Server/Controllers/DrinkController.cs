using Cafe_Lazar.Server.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_Lazar.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinkController : ControllerBase
    {

        private readonly ILogger<DrinkController> _logger;

        public DrinkController(ILogger<DrinkController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetListOfDrink")]
        public IEnumerable<Drink> GetListOfDrink()
        {
           return  ListOfDrink.GetAllDrink();
        }
       
    }
}
