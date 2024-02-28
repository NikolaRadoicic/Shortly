using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            //Data is from DataBase
            {
                ViewData["ShortenedUrl"] = "This is just a short url";
                ViewData["AllUrls"] = new List<string>();
                { }

                return View();
            }




        }
    }
}
