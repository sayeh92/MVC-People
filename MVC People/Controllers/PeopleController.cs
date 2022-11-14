using Microsoft.AspNetCore.Mvc;
using MVC_People.Models.Repo;
using MVC_People.Models.Services;
using MVC_People.Models;
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
            return View(_peopleService.All());
        }
    }
}
