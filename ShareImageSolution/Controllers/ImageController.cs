using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShareImageSolution.Data;
using ShareImageSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImageSolution.Controllers
{
    public class ImageController : Controller
    {
        private readonly ShareImageDbContext _context;
        public ImageController(ShareImageDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Detail(int? id)
        {
            ViewData["Images"] = _context.Image.ToList();
            if(id == null)
            {
                return NotFound();
            }
            var image = await _context.Image.FirstOrDefaultAsync(x => x.ImageId == id);

            if(image == null)
            {
                return NotFound();
            }

            return View(image);
        }
        public async Task<IActionResult> SearchResult(string name)
        {
            ViewData["Images"] = _context.Image.ToList();


            var query = from img in _context.Image
                        join catg in _context.Category on img.CategoryId equals catg.CategoryId
                        select new { img, catg };

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => x.catg.NameCategory.Contains(name));
            }
            var result = await query.Select(x => new ImageCategoryViewModel()
            {
                Alt = x.img.Alt,
                ImageId =x.img.ImageId,
                CategoryId = x.img.CategoryId,
                Description =x.img.Description,
                NameCategory =x.catg.NameCategory,
                Path = x.img.Path,
                Suggesstion = x.catg.Suggesstion
            }).ToListAsync();

            
            return View(result);
           
        }

    }
}
