using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiDemo.Core.Contracts;
using TaxiDemo.Core.Models;

namespace TaxiDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {
        private readonly ITaxiService taxiService;
        public TaxiController(ITaxiService  _taxiService)
        {
            taxiService = _taxiService;
        }
        /// <summary>
        /// Get all avaiable Taxi vehicles
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200,StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<TaxiDto>))]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await taxiService.GetAll());
        }
    }
}
