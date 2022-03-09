using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Database;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToyController : ControllerBase
    {
        private KinderGardenContext dbContext;

        public ToyController(KinderGardenContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Route("/Owner/{childId:int}")]
        public async Task<ActionResult<Toy>> AddToy([FromRoute] int childId, [FromBody] Toy toy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var newToy = dbContext.AddToy(childId, toy);
                return Ok(newToy);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}