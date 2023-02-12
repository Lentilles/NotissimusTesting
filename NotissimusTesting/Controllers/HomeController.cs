using Microsoft.AspNetCore.Mvc;
using NotissimusTesting.DAL.Converter;
using NotissimusTesting.DAL.DB;
using NotissimusTesting.DAL.Models.Offers;
using System.Collections.Generic;
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
            var offer = FindOfferAndSave(12344);
            return View(offer);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public Offer FindOfferAndSave (int id)
        {
            //string path = "../xml/YML.xml";
            string path = "http://partner.market.yandex.ru/pages/help/YML.xml";

            var offers = xml2classes.ReadXml(path);
            var result = offers.Where(x => x.Id == id).First();
            var db = new OfferLoaderToDb();

            db.Create(result);

            return result;
        }

    }
}