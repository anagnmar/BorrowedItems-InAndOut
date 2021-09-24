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
	public class ExpenceseController : Controller
	{
		private readonly ApplicationDBContext _db;

		public ExpenceseController(ApplicationDBContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<Expencese> expList = _db.Expenceses;

			return View(expList);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();
		}

		//	POST: Create

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Create(Expencese exp)
		{
			_db.Expenceses.Add(exp);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}


	}
}
