using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		//[HttpGet]
		public ViewResult Index()
		{
			return View();
			//return RedirectToAction("sunita");
			//return Content("i am sunita");

			}
			//public RedirectToActionResult Index()
			//{

			//	return RedirectToAction("sunita");


			//}
			//public IActionResult Index()
			//{

			//	return Content("i am sunita");

			//}
			public JsonResult JsonResult()
		{
			
			return Json(
				new
				{
					name="sunita", Class="csit" , rollNo=34
				});

		}
		public FileResult Download()
		{
			string name = "myfiles/sunita.txt";
			string ext = "image/png";
			return File("myfiles/sunita.jpg",ext, name);
		}



		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult sunita()
		{
			return View();
		}
		public IActionResult suman()
		{
			return View();
		}
		public IActionResult amy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

	}
}