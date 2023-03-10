using Microsoft.AspNetCore.Mvc;
using UsingPartialViews.Data;

namespace UsingPartialViews.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public StudentController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var model = applicationDbContext.Students.ToList();
            return View(model);
        }
    }
}
