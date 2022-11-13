using Microsoft.AspNetCore.Mvc;
using MVC_People.Models.Repo;
using MVC_People.Models.Services;

namespace MVC_People.Controllers
{
    public class PeopleController : Controller
    {
        IpeopleService _peopleService;
        public PeopleController ()
        {
            _peopleService = new PeopleService(new InMemoryPeopleRepo());
        }

        public IActionResult PersonPage()
        {
            return View();
        }
    }
}
