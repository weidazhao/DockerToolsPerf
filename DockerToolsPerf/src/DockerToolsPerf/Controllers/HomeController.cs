using Microsoft.AspNetCore.Mvc;

namespace DockerToolsPerf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page. " + MyClassLib.MyLib.OSDescription;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page. " + MyClassLib.MyLib.FrameworkDescription;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
