namespace Cafe_Lazar.Server.Model
{
    public class Ingredient
    {
        public int PricePerDose { get; set; }
        public string Name { get; set; }


        public Ingredient (int price, string name)
        {
            PricePerDose= price;
            Name= name;
        }
    }
}
