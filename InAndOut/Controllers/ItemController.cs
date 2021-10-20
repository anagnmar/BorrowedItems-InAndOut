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
		private readonly ApplicationDBContext _db;

		public ItemController(ApplicationDBContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<Item> objList = _db.Items;

			return View(objList);
		}

	//	GET : Index/id  -  Item(id)

		public IActionResult Details(int? id)
		{
			if (id == null)
				return NotFound();

			Item item = _db.Items.Find(id);

			if (item == null)
				return NotFound();

			return View(item);
		}

	//	GET: Create
		public IActionResult Create()
		{
			return View();
		}

	//	POST: Create

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Create(Item obj)
		{
			_db.Items.Add(obj);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

	// GET : Delete

		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			var delItem = _db.Items.Find(id);

			if (delItem == null)
				return NotFound();

			return View(delItem);
		}

	// POST : Delete

		[HttpPost]
		public IActionResult DeletePost(int? id)
		{
			var delItem = _db.Items.Find(id);

			if (delItem == null)
			{
				return NotFound(delItem);
			}

				_db.Items.Remove(delItem);
				_db.SaveChanges();

			return RedirectToAction("Index");
		}

		// GET : Update

		[HttpGet]
		public IActionResult Update(int? id)
		{

			if (id == null || id == 0)
			{
				return NotFound();
			}

			var updItem = _db.Items.Find(id);

			if (updItem == null)
				return NotFound();

			return View(updItem);
		}

		// POST: Update

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Update(Item upItem)
		{
			if (!ModelState.IsValid)
			{
				return View(upItem);
			}
			else
			{
				_db.Items.Update(upItem);
				_db.SaveChanges();
			}

			return RedirectToAction("Index");
		}


	}
}
