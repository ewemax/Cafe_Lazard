using Cafe_Lazar.Server.Model;
using Cafe_Lazard.Server.Interface;

namespace Cafe_Lazard.Server.Services
{
    public class DrinkService : IDrinkService
    {
        public List<Drink> GetallDrinks ()
        {
            return ListOfDrink.GetAllDrink ();
        }

        public DrinkService()
        {

        }
    }
}
