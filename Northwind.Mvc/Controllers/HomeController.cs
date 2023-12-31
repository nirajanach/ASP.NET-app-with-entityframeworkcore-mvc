﻿using Microsoft.AspNetCore.Mvc; //Controller, IActionResult
using Northwind.Mvc.Models; //ErrorViewModel
using System.Diagnostics; //Activity
using Packt.Shared; //NorthwindContext

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext db;

        public HomeController(ILogger<HomeController> logger, NorthwindContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new
                (
                VisitorCount: Random.Shared.Next(1, 1001),
                Categories: db.Categories.ToList(),
                Products: db.Products.ToList()
                );
            return View(model);


            _logger.LogError("This is a serious error(not really!)");
            _logger.LogWarning("This is your first warning.");
            _logger.LogWarning("Second Warning.");
            _logger.LogInformation("I am in the Index method of the HomeController.");
            return View();
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