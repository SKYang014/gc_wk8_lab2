using lab8._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace lab8._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FirstSignUp(string fName, string lName, string password)
        {

            ViewBag.fName = fName;
            ViewBag.lName = lName;
            ViewBag.Password = password;
            return View();
        }
        public IActionResult ProcessLogin(string fName, string trainerId, string password)
        {
            Random random = new Random();
            int number = random.Next(1,150);
            int space = random.Next(1, 240);


            ViewBag.fName = fName;
            ViewBag.TrainerId = trainerId;
            ViewBag.Password = password;
            ViewBag.Pokedex = number;
            ViewBag.Space = space;


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}