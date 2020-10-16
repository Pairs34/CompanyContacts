using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rehber.Models;

namespace Rehber.Controllers
{
    public class Course : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks",student);
            }
            else
            {
                return View(student);
            }
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult list()
        {
            var students = Repository.students.Where(x => x.confirm == true);
            return View(students);
        }
    }
}