using DemoProjectMVC.DbCon;
using DemoProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly MVCContext _mvcContext;
       
        public StudentController(MVCContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

        public async Task <ActionResult> Index()

        {
            var data = await _mvcContext.Students.ToListAsync();
            return View(data);
        }

       public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student students)
        {
            if (!ModelState.IsValid)
            {
                return View(students);
            }

            return View();
        }
    }
}
