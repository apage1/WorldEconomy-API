using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldEconomy.Models;
using WorldEconomy.ApiHelpers;
namespace WorldEconomy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
                    return View();
        }

        public IActionResult Data()
        {
            //ViewData["Message"] = "Your application description page.";
            var WealthiestNations = WorldBankDataHelpers.GetWealthiestNationsGdpUsd();

            return View(WealthiestNations);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Andrew Page";

            return View();
        }

        public IActionResult Visual()
        {
            //ViewData["Message"] = "Your Visual page.";

            //return View();

            var WealthiestNations = WorldBankDataHelpers.GetWealthiestNationsGdpUsd();


            return View(WealthiestNations);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Factors()
        {
            ViewData["Title"] = "Factors";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()

        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
