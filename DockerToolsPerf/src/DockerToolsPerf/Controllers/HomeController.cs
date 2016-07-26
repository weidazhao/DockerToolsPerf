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
            ViewData["Message"] = "Your application description page. " + new MyClassLib.MyLib().Value;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page. " + new MyClassLib.MyLib().Value;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
