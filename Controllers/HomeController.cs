using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebToDo.Data;
using WebToDo.Models;

namespace WebToDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationDbContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await db.Tasks.ToListAsync());
        }

        [HttpPost]
        public IActionResult Create(ToDoModel toDo)
        {
            ViewBag.TaskTitle = toDo.TaskTitle;
            db.Tasks.Add(toDo);
            db.SaveChanges();
            return View("Create");
        }


        //[HttpPost]
        //public async Task<IActionResult> Create(ToDoModel toDo)
        //{
        //    db.Tasks.Add(toDo);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
