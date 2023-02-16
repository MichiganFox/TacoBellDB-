using CreatingASQLDBTacoBellDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreatingASQLDBTacoBellDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Drink> GetAll()
        {
            return dbContext.Drinks.ToList();
        }
        [HttpGet("Name")]//the Category must match to the string Category in the method.  It will allow the value that is is serach for and is stored in the method category 
        public List<Drink> GetByCategory(string name)
        {
            return dbContext.Set<Drink>().ToList();
           
        }
        [HttpPost]
        public Drink AddDrink(string Name, float Cost, bool Slushie)
        {
            Drink newDrink = new Drink(Name, Cost, Slushie);
            dbContext.Add(newDrink);
            return newDrink;
        }
        [HttpDelete]
        public Drink DeleteDrink(string Name) 
        { 
            Drink d = dbContext.Drinks.FirstOrDefault(x => x.Name == Name);
            dbContext.Remove(d);
            return d;
        }
    }
}
