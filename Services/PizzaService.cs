using BlazingPizza.Data;

namespace BlazingPizza.Services
{
    public class PizzaService
    {
        public async Task<List<PizzaModel>> GetPizzasAsync()
        {


            List<PizzaModel> specials = new (){ 
				new PizzaModel { PizzaId = 1, Name = "Calabresa", Description = "Tem calabresa", Price = 10.00M, Vegan = false, Vegetarian = false},
				new PizzaModel { PizzaId = 2, Name = "Araruama", Description = "Tem calabresa", Price = 10.00M, Vegan = false, Vegetarian = false},
              };

            return await Task.FromResult(specials);
            
		}
    }
}
