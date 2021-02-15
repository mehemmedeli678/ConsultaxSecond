using Consultaxsecond.Data;
using Consultaxsecond.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Areas.K207Admin.Controllers
{
    [Area("K207Admin")]
    public class AdminSection1Controller : Controller
    {
        ConsultaxSecondDB _context;
        private IWebHostEnvironment _webHostEnvironment;

        public AdminSection1Controller(ConsultaxSecondDB context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.Section1.ToList());
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Section1 section)
        {
            _context.Section1.Update(section);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Section1 sect,IFormFile Photo)
        {

            if (Photo != null)
            {
                string imgName = Guid.NewGuid() + Photo.FileName;
               string folder= Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                string imgUrl = Path.Combine(folder, imgName);
               using FileStream filestream = new FileStream(imgUrl,FileMode.Create);
                Photo.CopyTo(filestream);
                sect.PhotoUrl = imgName;
            }
            _context.Section1.Add(sect);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int? id)
        {
            Section1 selectedSect = _context.Section1.FirstOrDefault(s => s.ID == id);
            return View(selectedSect);
        }

        [HttpPost]
        public IActionResult Delete(int ID)
        {
           var selectedsec=_context.Section1.Find(ID);
            _context.Section1.Remove(selectedsec);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
