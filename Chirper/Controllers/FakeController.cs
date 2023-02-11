using Microsoft.AspNetCore.Mvc;

namespace Chirper.Controllers
{
    public class FakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
