using System;

namespace shop
{
    public class FizzyDrink
    {
        public string DrinkName { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }

        public FizzyDrink(string drinkName, decimal price, int size)
        {
            DrinkName = drinkName;
            Price = price;
            Size = size;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an array of FizzyDrink objects
            FizzyDrink[] fizzyDrinks = new FizzyDrink[]
            {
                new FizzyDrink("Foxton Fizz", 1.5m, 12),
                new FizzyDrink("L&P", 1.0m, 16),
                new FizzyDrink("Fanta", 1.25m, 20),
                new FizzyDrink("Coke", 1.25m, 20),
                new FizzyDrink("Sprite", 1.25m, 20)
            };

            // Display the contents of the array
            Console.WriteLine("Fizzy Drinks:");
            foreach (var drink in fizzyDrinks)
            {
                Console.WriteLine($"Name: {drink.DrinkName}, Price: ${drink.Price}, Size: {drink.Size} oz");
            }
        }
    }
}
