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
	public class ExpenseController : Controller
	{
		private readonly ApplicationDBContext _db;

		public ExpenseController(ApplicationDBContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<Expense> expList = _db.Expenses;

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
		public IActionResult Create(Expense exp)
		{
			_db.Expenses.Add(exp);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}


	}
}
