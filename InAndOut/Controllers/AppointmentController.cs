using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace InAndOut.Controllers
{
	public class AppointmentController : Controller
	{
		public IActionResult Index()
		{
			string todayDate = DateTime.Now.ToShortDateString();
			// return Ok(todayDate);

			return View();
		}

		public IActionResult Details(int id)
		{

			return Ok($"You have entered id: "+ id);
		}

	}
}
