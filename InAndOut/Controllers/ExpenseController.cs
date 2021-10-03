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

	//	GET : INDEX / ALL EXPENSES

		public IActionResult Index()
		{
			IEnumerable<Expense> expList = _db.Expenses;

			return View(expList);
		}

	//	GET : INDEX/id  -  Expense(id)

		public IActionResult Details(int? id)
		{
			if (id == null)
				return NotFound();

			Expense expense = _db.Expenses.Find(id);

			if (expense == null)
				return NotFound();

			return View(expense);
		}

	// POST: CREATE

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Create(Expense exp)
		{
			if (!ModelState.IsValid)
			{
				return View(exp);
			}
			else
			{
				_db.Expenses.Add(exp);
				_db.SaveChanges();
			}

			return RedirectToAction("Index");
		}

	// GET : Delete

		public IActionResult Delete(int? id)
		{

			if (id == null || id == 0)
			{
				return NotFound();
			}

			var delObj = _db.Expenses.Find(id);

			if (delObj == null)
				return NotFound();

			return View(delObj);
		}

	// POST : Delete

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int id)
		{
			var delExp = _db.Expenses.Find(id);

			if (delExp == null)
				return NotFound();
			

				_db.Expenses.Remove(delExp);
				_db.SaveChanges();

			return RedirectToAction("Index");
		}


	}
}
