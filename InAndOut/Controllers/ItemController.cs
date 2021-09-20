using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using InAndOut.Data;
using InAndOut.Models;


namespace InAndOut.Controllers
{
	public class ItemController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
