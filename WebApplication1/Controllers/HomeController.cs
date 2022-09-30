using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        StudentMark [] studentMarkArray = { 
            new StudentMark {
                FirstName = "Cергій",
                LastName = "Гаврилюк",
                FatherName = "Іванович",
                Mark = 4,
                Subject = "Громадянська освіта",
                Date = DateTime.Now.AddDays(-20).AddHours(-3)
            },
            new StudentMark {
                FirstName = "Андрій",
                LastName = "Карпенко",
                FatherName = "Миколайович",
                Mark = 2,
                Subject = "ТІМС",
                Date = DateTime.Now.AddDays(-11).AddHours(17)
            },
            new StudentMark {
                FirstName = "Микола",
                LastName = "Горбатий",
                FatherName = "Юрійович",
                Mark = 5,
                Subject = "Програмування на Python",
                Date = DateTime.Now.AddDays(-15).AddHours(5)
            },
            new StudentMark {
                FirstName = "Дмитро",
                LastName = "Хомяк",
                FatherName = "Олександрович",
                Mark = 1,
                Subject = "Вища математика",
                Date = DateTime.Now.AddDays(-17).AddHours(-2)
            },
            new StudentMark {
                FirstName = "Геннадій", 
                LastName = "Тимчеко",
                FatherName = "Вікторович",
                Mark = 3,
                Subject = "Програмування на С++",
                Date = DateTime.Now.AddDays(-8).AddHours(-18)
            }
        };
        [HttpGet]
        public ActionResult Index()
        {
            return View(studentMarkArray);
        }

        [HttpGet("below_three")]
        public ActionResult BelowThree()
        {
            return View(studentMarkArray);
        }
    }
}
