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
	public class ExpenseTypeController : Controller
	{
		private readonly ApplicationDBContext _db;

		public ExpenseTypeController(ApplicationDBContext db)
		{
			_db = db;
		}


		//	GET : INDEX / ALL EXPENSES

		public IActionResult Index()
		{
			IEnumerable<ExpenseType> expTypesList = _db.ExpenseTypes;

			return View(expTypesList);
		}

		//	GET : INDEX/id  -  Expense(id)

		public IActionResult Details(int? id)
		{
			if (id == null)
				return NotFound();

			ExpenseType expenseType = _db.ExpenseTypes.Find(id);

			if (expenseType == null)
				return NotFound();

			return View(expenseType);
		}


		// GET : Create

		//[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		// POST: Create

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Create(ExpenseType expType)
		{
			if (!ModelState.IsValid)
			{
				return View(expType);
			}
			else
			{
				_db.ExpenseTypes.Add(expType);
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

			var delObj = _db.ExpenseTypes.Find(id);

			if (delObj == null)
				return NotFound();

			return View(delObj);
		}

		// POST : Delete

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{
			var delExp = _db.ExpenseTypes.Find(id);

			if (delExp == null)
				return NotFound();


			_db.ExpenseTypes.Remove(delExp);
			_db.SaveChanges();

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

			var updObjT = _db.ExpenseTypes.Find(id);

			if (updObjT == null)
				return NotFound();

			return View(updObjT);
		}

		// POST: Update

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Update(ExpenseType upExpTypes)
		{
			if (!ModelState.IsValid)
			{
				return View(upExpTypes);
			}
			else
			{
				_db.ExpenseTypes.Update(upExpTypes);
				_db.SaveChanges();
			}

			return RedirectToAction("Index");
		}

	}
}
