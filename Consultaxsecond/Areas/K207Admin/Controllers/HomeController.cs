using Consultaxsecond.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Areas.K207Admin.Controllers
{
 
    public class HomeController : Controller
    {
        ConsultaxSecondDB _db;

        public HomeController(ConsultaxSecondDB db)
        {
            _db = db;
        }
        [Area("K207Admin")]
        public IActionResult Index()
        {
            return View(_db.Section1.ToList());
        }
    }
}
