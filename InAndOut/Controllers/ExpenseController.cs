using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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


	// GET : Create

		//[HttpGet]
		public IActionResult Create()
		{
			IEnumerable<SelectListItem> TypeDropDown = _db.ExpenseTypes.Select(t =>
					new SelectListItem
					{
						Text = t.Name,
						Value = t.Id.ToString()
					});

			ViewBag.TypeDropDown = TypeDropDown;

			return View();
		}

	// POST: Create

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



	// GET : Update

		//[HttpGet]
		public IActionResult Update(int? id)
		{

			if (id == null || id == 0)
			{
				return NotFound();
			}

			var updObj = _db.Expenses.Find(id);

			if (updObj == null)
				return NotFound();

			return View(updObj);
		}

	// POST: Update

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Update(Expense upExp)
		{
			if (!ModelState.IsValid)
			{
				return View(upExp);
			}
			else
			{
				_db.Expenses.Update(upExp);
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
		public IActionResult DeletePost(int? id)
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
