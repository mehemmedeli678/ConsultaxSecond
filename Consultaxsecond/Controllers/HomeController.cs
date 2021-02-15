using Consultaxsecond.Data;
using Consultaxsecond.Models;
using Consultaxsecond.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       private ConsultaxSecondDB _db;

        public HomeController(ILogger<HomeController> logger,ConsultaxSecondDB db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            indexVM vm = new indexVM();
            vm.Section1 = _db.Section1.ToList();
            vm.Section2 = _db.Section2.ToList();
            return View(vm);
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
