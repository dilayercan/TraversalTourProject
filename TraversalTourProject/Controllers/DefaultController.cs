using Microsoft.AspNetCore.Mvc;

namespace TraversalTourProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
