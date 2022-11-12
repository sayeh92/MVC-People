using Microsoft.AspNetCore.Mvc;

namespace MVC_People.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult PersonPage()
        {
            return View();
        }
    }
}
