using FastReport.Web;
using FastTest.Data;
using FastTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FastTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationDbContext _context;
        IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var myReport = new HomeModel()
            {
                WebReport = new WebReport(),
            };

            string path = _hostEnvironment.WebRootPath + "\\Reports\\Untitled.frx";

            myReport.WebReport.Report.Load(path);
            var myEmployeesList = await _context.AAAA_PRINT_KREDIT.ToListAsync();
            var myConvertedTable = Services.ConvertToDataSet(myEmployeesList, "AAAA_PRINT_KREDIT");


            myReport.WebReport.Report.RegisterData(myConvertedTable, "Database");
            return View(myReport);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}