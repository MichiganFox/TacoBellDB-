using CreatingASQLDBTacoBellDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreatingASQLDBTacoBellDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurittoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Burrito> GetAll()
        {
            return dbContext.Burritos.ToList();
        }
        [HttpGet("Name")]//the Category must match to the string Category in the method.  It will allow the value that is is serach for and is stored in the method category 
        public List<Burrito> GetByCategory(string name)
        {
            return dbContext.Set<Burrito>().ToList();
        }
    }
   
}
