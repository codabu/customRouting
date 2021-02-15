using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No ID supplied.");
            }
            else
            {
                return Content("ID: " + id);
            }
        }

        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "")
        {
            string contentString = "Counting down:\n";
            for (int i = start; i >= end; i--)
            {
                contentString += i + "\n";
            }
            return Content(contentString + message);
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Dummy1()
        {
            return View();
        }

        public IActionResult Dummy2(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return Content("ID: " + id);
            }

        }

        [Route("Retail/[action]/{id?}")]
        public IActionResult Dummy3()
        {
            return View();
        }
    }
}
