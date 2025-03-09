using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class ProjectsController : Controller
{
    [Route("/")]
    [Route("/Projects")]
    public IActionResult Index()
    {
        return View();
    }
}
