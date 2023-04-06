using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class NistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
