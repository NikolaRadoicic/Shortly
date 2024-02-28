using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;
using System.Collections.Generic; // Added for List<T>

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            // Fake db data
            var allUrls = new List<Url>()
            {
                new Url()
                {
                    Id = 1,
                    OriginalLink = "https://link1.com",
                    ShortLink = "sh1",
                    NumberOfClicks = 1,
                    UserId = 1,
                },

                new Url()
                {
                    Id = 2,
                    OriginalLink = "https://link2.com", // Corrected link
                    ShortLink = "sh2",
                    NumberOfClicks = 2,
                    UserId = 2,
                },

                new Url()
                {
                    Id = 3,
                    OriginalLink = "https://link3.com",
                    ShortLink = "sh3",
                    NumberOfClicks = 3,
                    UserId = 3,
                } 
            };

            // Pass the data to the view
            return View(allUrls);
        }

        public IActionResult Create()
        {
            return RedirectToAction("Index");
        }
    }
}
