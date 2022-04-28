using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private List<string> Cheeses = new List<string>();
        public IActionResult Index()
        {

            ViewBag.cheeses = Cheeses;

            return View();
        }
        public IActionResult Add()
        {
            return View();

        }
        public IActionResult Remove()
        {

            ViewBag.cheeses = Cheeses;
            return View();

        }
        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name)
        {
            Cheeses.Add(name);
            return Redirect("/Cheese");
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RemoveCheese(string name)
        {
            Cheeses.Remove(name);
            return Redirect("/Cheese");
        }
    }
}
