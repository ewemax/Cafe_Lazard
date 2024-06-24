namespace Cafe_Lazar.Server.Model
{
    //everything here should be done via a BDD and request or entityframework
    public static class ListOfIngredient
    {
        public static Ingredient PowderMilk = new Ingredient(10, "PowderMilk");
        public static Ingredient Coffe = new Ingredient(30, "Coffe");
        public static Ingredient ChocolatePowder = new Ingredient(40, "ChocolatePowder");
        public static Ingredient Tea = new Ingredient(30, "Tea");
        public static Ingredient Water = new Ingredient(5, "Water");
    }

    public static class ListOfDrink
    {
         
        public static Drink Espresso = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.Water, 2},
                                                        { ListOfIngredient.Coffe, 1}
                                                    }, "Espresso");
        public static Drink Milk = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.PowderMilk, 2},
                                                        { ListOfIngredient.Water, 1}
                                                    }, "Milk");
        public static Drink Cappuccino = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.PowderMilk, 2},
                                                        { ListOfIngredient.Water, 1},
                                                        { ListOfIngredient.Coffe, 1},
                                                        { ListOfIngredient.ChocolatePowder, 1}
                                                    }, "Cappuccino");

        public static Drink Hotchocolate = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.Water, 3},
                                                        { ListOfIngredient.ChocolatePowder, 2}
                                                    }, "Hotchocolate");
        public static Drink MilkCoffe = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.PowderMilk, 1},
                                                        { ListOfIngredient.Water, 2},
                                                        { ListOfIngredient.Coffe, 1}
                                                    }, "MilkCoffe");

        public static Drink Mokaccino = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.PowderMilk, 1},
                                                        { ListOfIngredient.Water, 2},
                                                        { ListOfIngredient.Coffe, 1},
                                                        { ListOfIngredient.ChocolatePowder, 2}
                                                    }, "Mokaccino");
        public static Drink Tea = new Drink(new Dictionary<Ingredient, int>()
                                                    {
                                                        { ListOfIngredient.Water, 2},
                                                        { ListOfIngredient.Tea, 1}
                                                    }, "Tea");

        public static List<Drink> GetAllDrink()
        {
            return new List<Drink>()
            {
                Espresso,Milk,Cappuccino,Hotchocolate,MilkCoffe,Mokaccino,Tea
            };
        }
    }
}
