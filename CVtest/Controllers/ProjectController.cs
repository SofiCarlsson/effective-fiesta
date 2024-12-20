using Microsoft.AspNetCore.Mvc;

namespace CVtest.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
