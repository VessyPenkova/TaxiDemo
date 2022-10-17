using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiDemo.Core.Contracts;

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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await taxiService.GetAll());
        }
    }
}
