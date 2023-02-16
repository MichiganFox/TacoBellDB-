using CreatingASQLDBTacoBellDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CreatingASQLDBTacoBellDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Taco> GetAll()
        {
            return dbContext.Tacos.ToList();
        }
        [HttpGet("Name")]//the Category must match to the string Category in the method.  It will allow the value that is is serach for and is stored in the method category 
        public List<Taco> GetByCategory(string name)
        {
            return dbContext.Set<Taco>().ToList();
        }
        [HttpPost]
        public Taco AddTaco(string Name, float Cost, bool Softshell, bool Dorito)
        {
            Taco newTaco = new Taco(Name, Cost, Softshell, Dorito);
            dbContext.Add(newTaco);
            return newTaco;
        }
    }
}
