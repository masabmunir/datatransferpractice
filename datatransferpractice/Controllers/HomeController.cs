using datatransferpractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace datatransferpractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly TeacherDBContext teacherDB;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(TeacherDBContext teacherDB)
        {
            this.teacherDB = teacherDB;
        }

        public IActionResult TeacherDetail()
        {
            var teacher = teacherDB.Teachers.ToList(); // used to access data from database
            return View(teacher);

        }

        public IActionResult Index()
        {
           var myEmployee = new List<Employee>
            { new Employee {employeeId = 1, employeeName = "Masab",  employeeTitle = "Developer" },
              new Employee {employeeId = 2, employeeName = "Ali",  employeeTitle = "Engineer" },
              new Employee {employeeId = 3, employeeName = "Hassan",  employeeTitle = "Developer" },

            };
            //ViewData["Data1"] = myEmployee;
            //ViewBag.Data1 = myEmployee;
            return View(myEmployee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Student stu)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Form submitted successfully!";
                return RedirectToAction("Signup");
            }

            return View(stu);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
