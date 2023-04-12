using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class HomeController2 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
