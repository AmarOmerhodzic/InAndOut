using System.Collections.Generic;
using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;

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

        // GET-Create
		public IActionResult Create()
		{
			
			return View();
		}

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Create(Item obj)
		{
            _db.Items.Add(obj);
            _db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
