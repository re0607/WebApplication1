using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMvc.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
