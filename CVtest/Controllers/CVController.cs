using Microsoft.AspNetCore.Mvc;

namespace CVtest.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
