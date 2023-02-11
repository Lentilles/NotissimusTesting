using Microsoft.AspNetCore.Mvc;
using NotissimusTesting.DAL.Models.Offers;
using System.Diagnostics;
using System.Xml;

namespace NotissimusTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public List<Offer> XMLToOffers(string path)
        {
            /*
             * XmlDocument document = new XmlDocument();
                document.Load(path);
            */
            using (XmlReader reader = XmlReader.Create(path))
            {

            }
            
        }
    }
}