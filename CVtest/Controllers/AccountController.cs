using Microsoft.AspNetCore.Mvc;

namespace CVtest.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
