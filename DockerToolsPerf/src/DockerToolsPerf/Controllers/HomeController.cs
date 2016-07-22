using Microsoft.AspNetCore.Mvc;

namespace DockerToolsPerf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new OkObjectResult("Hello world");
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
