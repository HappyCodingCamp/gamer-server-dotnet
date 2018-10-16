using System.Collections.Generic;
using GamerServer.Models.Api;
using GamerServer.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace GamerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HappinessesController : ControllerBase
    {
        private readonly GamerAiContext _dbContext;

        public HappinessesController(GamerAiContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_dbContext.Happinesses);
        }

        [HttpPost]
        public ActionResult<Happiness> Create([FromBody] HappinessRequest happinessRequest)
        {
            Happiness happiness = new Happiness { Level = happinessRequest.Level};
            
            _dbContext.Happinesses.Add(happiness);
            _dbContext.SaveChanges();

            return happiness;
        }
    }
}
