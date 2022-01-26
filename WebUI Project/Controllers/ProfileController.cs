using Microsoft.AspNetCore.Mvc;

namespace WebUI_Project.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
