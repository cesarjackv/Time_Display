using Microsoft.AspNetCore.Mvc;
namespace Time_Display.Controllers;     //be sure to use your own project's namespace!
    public class Time_DisplayController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            ViewBag.Time = DateTime.Now;
            return View();
        }
}

