using Microsoft.AspNetCore.Mvc;
using TaxiDemo.Core.Contracts;

namespace TaxiDemo.Controllers
{
    /// <summary>
    /// //Web Taxi Product
    /// </summary>

    public class TaxiController : Controller
    {
        /// <summary>
        /// List All requests for taxi
        /// </summary>
        /// <returns></returns>
        private readonly ITaxiService taxiService;
        public TaxiController(ITaxiService _taxiService)
        {
             taxiService = _taxiService;
        }
      
        public async Task<IActionResult> Index()
        {
            var taxi = await taxiService.GetAll();
            ViewData["Title"] = "Taxi";

            return View(taxi);
        }
    }
}
