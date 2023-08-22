namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<List<Pizza>> GetPizzasAsync()
    {
        return Task.FromResult(new List<Pizza>
        {
            new Pizza
            {
                PizzaId = 1,
                Name = "Pizza Margherita",
                Description = "The classic. Fresh tomatoes, garlic, olive oil, and basil. Vegetarian.",
                Price = 9.99m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 2,
                Name = "Pizza Napoletana",
                Description =
                    "Authentic Neapolitan pizza. San Marzano tomatoes, garlic, oregano, and extra virgin olive oil. Vegetarian. Vegan option available.",
                Price = 10.99m,
                Vegetarian = true,
                Vegan = true
            },
            new Pizza
            {
                PizzaId = 3,
                Name = "Pizza Bianca",
                Description = "Olive oil, salt, rosemary, and garlic on our housemade crust. Vegan.",
                Price = 8.99m,
                Vegetarian = true,
                Vegan = true
            },
            new Pizza
            {
                PizzaId = 4,
                Name = "Pizza Marinara",
                Description = "The classic. Fresh tomatoes, garlic, olive oil, and basil. Vegetarian.",
                Price = 7.99m,
                Vegetarian = true,
                Vegan = true
            },
            new Pizza
            {
                PizzaId = 5,
                Name = "Pizza Funghi",
                Description = "Fresh mushrooms, olives, mozzarella, and our housemade tomato sauce. Vegetarian.",
                Price = 11.99m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 6,
                Name = "Pizza Quattro Formaggi",
                Description =
                    "Mozzarella, parmesan, romano, and fontina cheeses, and our housemade tomato sauce. Vegetarian.",
                Price = 11.99m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 7,
                Name = "Pizza Vegetariana",
                Description =
                    "Roasted peppers, onions, mushrooms, tomatoes, and our housemade tomato sauce. Vegetarian. Vegan option available.",
                Price = 11.99m,
                Vegetarian = true,
                Vegan = true
            }
        });
    }
}