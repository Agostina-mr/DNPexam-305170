using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPI.Database;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChildrenController : ControllerBase
    {
        private KinderGardenContext dbContext;

        public ChildrenController(KinderGardenContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Child>> AddChild([FromBody] Child child)
        {
            try
            {
                var newChild = await dbContext.AddChild(child);
                return Ok(JsonConvert.SerializeObject(child));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Child>>> GetAllChildren()
        {
            try
            {
                var all = await dbContext.GetAllChildren();
                return Ok(JsonConvert.SerializeObject(all));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete]
        [Route("/Children/Toys/{toyId:int}")]

        public async Task<OkResult> DeleteToy([FromRoute] int toyId)
        {
            try
            {
                await dbContext.DeleteToy(toyId);
                return Ok();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }



    }
}