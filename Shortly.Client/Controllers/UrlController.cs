using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.ViewModels;
using Shortly.Data;
using System.Collections.Generic;

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        private readonly AppDbContext _context;

        public UrlController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allUrls = _context.Urls
                .Select(url => new GetUrlVM
                {
                    Id = url.Id,
                    OriginalLink = url.OriginalLink,
                    ShortLink = url.ShortLink,
                    NumberOfClicks = url.NumberOfClicks,
                    UserId = url.UserId
                })
                .ToList();

            return View(allUrls);
        }

        public IActionResult Create()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            return View();
        }

        public IActionResult Remove(int userId, int linkId)
        {
            return View();
        }
    }
}
