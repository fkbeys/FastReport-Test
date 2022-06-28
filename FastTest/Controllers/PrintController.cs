using FastReport.Web;
using FastTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace FastTest.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class PrintController : Controller
    {
        IWebHostEnvironment _hostEnvironment;
        public PrintController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var myReport = new HomeModel()
            {
                WebReport = new WebReport(),
            };

            List<AAAA_PRINT_KREDIT> model = new List<AAAA_PRINT_KREDIT>();

            model.Add(new AAAA_PRINT_KREDIT {  PRINT_ID=0, PRINT_AVTOMOBILIN_DEYERI=1, PRINT_AYLIQ_ODEME=1,PRINT_BANK_XIDMETI=1, PRINT_BAZI_TOPLAMLAR=0, PRINT_DYP_QEYDIYATI=1,
            PRINT_FAIZLERDEN_ODEMELER=1, PRINT_GUZEST_MUDDETI="1", PRINT_ILKIN_ODENIS=1 , PRINT_ILLIK_FAIZ="1", PRINT_KREDITIN_MEBLEGI=1, PRINT_KREDITTEN_ODEMELER=1,
            PRINT_KREDIT_MUDDETI="", PRINT_KREDIT_QALIQLARI=2, PRINT_MUSTERI_ADI_FAMILYASI="", PRINT_ODEME_TARIXI=new DateTime(2011,11,22), PRINT_ODENMELI_MEBLEG=0, 
                PRINT_SIGORTA=0, PRINT_SIRA=1
            } );


            string path = _hostEnvironment.WebRootPath + "\\Reports\\Untitled.frx";

            myReport.WebReport.Report.Load(path);
            var myConvertedTable = Services.ConvertToDataSet(model, "AAAA_PRINT_KREDIT");


            myReport.WebReport.Report.RegisterData(myConvertedTable, "Database");
            return View(myReport);
        }



        //[HttpGet]
        //public IActionResult Index([FromBody] List<AAAA_PRINT_KREDIT> model)
        //{
        //    var myReport = new HomeModel()
        //    {
        //        WebReport = new WebReport(),
        //    };

        //    string path = _hostEnvironment.WebRootPath + "\\Reports\\Untitled.frx";

        //    myReport.WebReport.Report.Load(path);
        //    var myConvertedTable = Services.ConvertToDataSet(model, "AAAA_PRINT_KREDIT");


        //    myReport.WebReport.Report.RegisterData(myConvertedTable, "Database");
        //    return View(myReport);
        //}
    }
}
