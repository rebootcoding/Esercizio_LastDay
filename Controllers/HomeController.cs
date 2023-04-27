using Esercizio_LastDay.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercizio_LastDay.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(string Username, string Password)
		{
			if (Manager.Login(Username, Password)){
				return RedirectToAction("ListaProdotti");
			}
			else
			{
				return RedirectToAction("Login");
			}
		}

		public IActionResult ListaProdotti()
		{
			return View(Manager.GetPhones());
		}

		[HttpPost]
		public IActionResult ListaProdotti(Cellulare c)
		{
			return View("AcquistoConfermato");
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

	}
}