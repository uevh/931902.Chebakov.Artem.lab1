using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CalculationsController : Controller
    {
        Random rand = new Random();
        private readonly ILogger<CalculationsController> _logger;

        public CalculationsController(ILogger<CalculationsController> logger)
        {
            
            _logger = logger;
        }

        public IActionResult PassUsingModel()
        {
            Arithmetic_Operations Temp = new Arithmetic_Operations();
            Temp.FirstNumber = rand.Next(0, 10);
            Temp.SecondNumber= rand.Next(0, 10);
            Temp.Sum = Temp.FirstNumber + Temp.SecondNumber;
            Temp.Difference = Temp.FirstNumber - Temp.SecondNumber;
            Temp.Product = Temp.FirstNumber * Temp.SecondNumber;
            if (Temp.SecondNumber != 0)
                Temp.Quotient = ""+Temp.FirstNumber / Temp.SecondNumber;
            else
                Temp.Quotient = "Error: DIVISION BY ZERO";
            return View(Temp);
        }

        public IActionResult PassUsingViewData()
        {
            Random rand = new Random();
            double FirstNumber, SecondNumber;
            FirstNumber = rand.Next(0, 10);
            SecondNumber = rand.Next(0, 10);
            ViewData["FirstNumber"] = FirstNumber;
            ViewData["SecondNumber"] = SecondNumber;
            ViewData["Sum"] = FirstNumber + SecondNumber;
            ViewData["Difference"] =FirstNumber - SecondNumber;
            ViewData["Product"] =  FirstNumber * SecondNumber;
            if (SecondNumber != 0)
                ViewData["Quotient"] = "" + (FirstNumber / SecondNumber);
            else
                ViewData["Quotient"] = "Error: DIVISION BY ZERO";


            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            Random rand = new Random();
            double FirstNumber, SecondNumber;
            FirstNumber = rand.Next(0, 10);
            SecondNumber = rand.Next(0, 10);
            ViewBag.FirstNumber = FirstNumber;
            ViewBag.SecondNumber = SecondNumber;
            ViewBag.Sum= FirstNumber + SecondNumber;
            ViewBag.Difference= FirstNumber - SecondNumber;
            ViewBag.Product = FirstNumber * SecondNumber;
            if (SecondNumber != 0)
                ViewBag.Quotient = "" + (FirstNumber / SecondNumber);
            else
                ViewBag.Quotient = "Error: DIVISION BY ZERO";
            return View();
        }

        public IActionResult AcessServiceDirectly()
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
