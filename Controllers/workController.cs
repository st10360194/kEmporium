using Microsoft.AspNetCore.Mvc;

namespace kEmporium.Controllers
{
    public class workController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
