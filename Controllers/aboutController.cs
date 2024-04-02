using Microsoft.AspNetCore.Mvc;

namespace kEmporium.Controllers
{
    public class aboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
