using data_collection.Data;
using data_collection.Models;
using Microsoft.AspNetCore.Mvc;

namespace data_collection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Confirmation(Widget widget)
        {
            return View(widget);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Widget widget)
        {
            if (ModelState.IsValid)
            {
                // Set the creation date and save the widget to the database
                widget.CreationDate = DateTime.Now;
                _context.Widgets.Add(widget);
                _context.SaveChanges();

                return RedirectToAction("Confirmation", widget);
            }

            // Display the data entry form with validation errors
            return View("Index", widget);
        }

        // AJAX endpoint to retrieve subtypes based on the selected type
        public JsonResult GetSubTypes(string type)
        {
            var subTypes = GetSubTypesByType(type);
            return Json(subTypes);
        }

        // Helper method to get subtypes based on the selected type
        private string[] GetSubTypesByType(string type)
        {
            switch (type)
            {
                case "A":
                    return new string[] { "Apple", "Aardvark", "Astronaut" };
                case "B":
                    return new string[] { "Bear", "Bobcat", "Beaver" };
                case "1":
                    return new string[] { "First", "One", "Primary", "Uno" };
                case "2":
                    return new string[] { "Second", "Two", "Secondary", "Dos" };
                default:
                    return new string[0];
            }
        }
    }
}
