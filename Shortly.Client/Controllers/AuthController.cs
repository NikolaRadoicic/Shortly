using Microsoft.AspNetCore.Mvc;

namespace Shortly.Client.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
