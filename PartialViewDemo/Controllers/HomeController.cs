using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViewDemo.Models;
using PartialViewDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly HiltonRepo Hilton = new HiltonRepo();
        private readonly HQRepo HQ = new HQRepo();


        public IActionResult Index()
        {
            var hq = HQ.Read();
            ViewBag.headquarter = hq;

            var hilton = Hilton.Find();

            return View(hilton);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
