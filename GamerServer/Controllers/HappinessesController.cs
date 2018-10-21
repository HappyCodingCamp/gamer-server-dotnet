using System.Collections.Generic;
using GamerServer.Models.Api;
using GamerServer.Models.Db;
using GamerServer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GamerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HappinessesController : ControllerBase
    {
        private readonly IWebApiRepository<HappinessRequest, HappinessResponse> _repository;

        public HappinessesController(IWebApiRepository<HappinessRequest, HappinessResponse> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<HappinessResponse>> Get()
        {
            return Ok(_repository.Get());
        }

        [HttpPost]
        public ActionResult<HappinessResponse> Create([FromBody] HappinessRequest happinessRequest)
        {
            HappinessResponse response = _repository.Add(happinessRequest);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
