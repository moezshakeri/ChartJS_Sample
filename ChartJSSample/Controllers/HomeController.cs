using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartJSSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<String> Labels = new List<string>();
            List<int> Values = new List<int>();

            Labels.Add("برنامه نویس");
            Labels.Add("دکتر");
            Labels.Add("پرستار");
            Labels.Add("راننده");

            Values.Add(30);
            Values.Add(0);
            Values.Add(50);
            Values.Add(75);

            ViewData["labels"] = Labels;
            ViewData["values"] = Values;
            
            
            


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}