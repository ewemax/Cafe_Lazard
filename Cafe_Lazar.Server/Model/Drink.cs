
namespace Cafe_Lazar.Server.Model
{
    public class Drink
    {

        public int TotalPrice { get; set; }

        public string Name { get; set; }

        public Drink (Dictionary<Ingredient, int> ingredients,string name)
        {
            Name = name;
            CalculatetotalPrice(ingredients);
        }

        private void CalculatetotalPrice(Dictionary<Ingredient, int> ingredients)
        {
            int price = 0;
            foreach (var  ingredient in ingredients)
            {
                price += ingredient.Value * ingredient.Key.PricePerDose;
            }
            TotalPrice = price+price*30/100;
        }
    }
}
