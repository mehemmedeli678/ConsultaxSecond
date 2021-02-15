using Consultaxsecond.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Areas.K207Admin.Controllers
{
    public class MyHomeController : Controller
    {
        ConsultaxSecondDB _context;

        public MyHomeController(ConsultaxSecondDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Section1.ToList());
        }
    }
}
