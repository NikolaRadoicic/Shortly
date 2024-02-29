using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;
using Shortly.Client.Data.ViewModels;
using System.Collections.Generic; 

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            // Fake db data
            var allUrls = new List<GetUrlVM>()
            {
                new GetUrlVM()
                {
                    Id = 1,
                    OriginalLink = "https://link1.com",
                    ShortLink = "sh1",
                    NumberOfClicks = 1,
                    UserId = 1,
                },

                new GetUrlVM()
                {
                    Id = 2,
                    OriginalLink = "https://link2.com", // Corrected link
                    ShortLink = "sh2",
                    NumberOfClicks = 2,
                    UserId = 2,
                },

                new GetUrlVM()
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
