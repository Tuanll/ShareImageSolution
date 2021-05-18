using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShareImageSolution.Data;
using ShareImageSolution.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImageSolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShareImageDbContext _context;
        public HomeController(ILogger<HomeController> logger, ShareImageDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index( int pag = 1)
        {
            int size = 9;
            int number = _context.Image.ToList().Count;
            int pageNum=  (int)Math.Ceiling((double)(number) / size);
            ViewData["pages"] = pageNum;
            ViewData["page"] = _context.Image.Skip((pag - 1) * size).Take(size).ToArray();
            return View(ViewData["page"]);
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
