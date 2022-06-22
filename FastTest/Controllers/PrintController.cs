using Microsoft.AspNetCore.Mvc;

namespace FastTest.Controllers
{
    public class PrintController : Controller
    {
        public PrintController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
